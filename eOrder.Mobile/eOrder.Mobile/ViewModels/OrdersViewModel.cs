using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using eOrder.Mobile.Models;
using Flurl.Http;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        APIService _ordersService = new APIService("OrderClient");
        APIService _orderDetailsService { get; set; } = new APIService("OrderDetails");
        public ObservableCollection<OrderModel> Orders { get; set; } = new ObservableCollection<OrderModel>();
        public ICommand InitCommand { get; set; }

        public OrdersViewModel()
        {
        }

        public OrdersViewModel(OrderStatus orderStatus)
        {
            OrderStatus = orderStatus;
            InitCommand = new Command(async () => await Init());
        }

        OrderStatus _orderStatus;
        public OrderStatus OrderStatus { get { return _orderStatus; } set { SetProperty(ref _orderStatus, value); }}

        public async Task Init()
        {
            var orders = await _ordersService.Get<IEnumerable<OrderDTO>>(new OrderSearchRequest
            {
                OrderStatus = OrderStatus,
                Organization = new OrganizationDTO()
            });

            Orders.Clear();
            foreach (var order in orders)
            {
                var orderDetails = await _orderDetailsService.Get<IEnumerable<OrderDetailsDTO>>(new OrderDetailsSearchRequest { OrderId = order.Id, Product = new ProductDTO() });
                Orders.Add(new OrderModel
                {
                    Order = order,
                    OrderDetailsList = orderDetails.Select(x => new OrderDetailModel
                    {
                        OrderDetail = x,
                        ProductPhotoUrl = $"{APIService._apiUrl}/Product/Photo/{x.ProductId}"
                    }).ToList()
                });
            }
        }

        public void OrderAll()
        {

        }
    }
}
