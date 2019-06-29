using eOrder.CORE.Requests;
using eOrder.Mobile.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        APIService _orderAPIService = new APIService("OrderClient");
        APIService _orderDetailsAPIService = new APIService("OrderDetails");

        int _orderId;
        OrderModel _order;
        public OrderModel Order { get { return _order; } set { SetProperty(ref _order, value); }}
        bool _isEditable;
        public bool IsEditable { get { return _isEditable; } set { SetProperty(ref _isEditable, value); } }

        ICommand InitCommand { get; set; }

        public OrderViewModel()
        {
        }

        public OrderViewModel(int id, bool isEditable)
        {
            _orderId = id;
            IsEditable = isEditable;;
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            Order = new OrderModel
            {
                Order = await _orderAPIService.GetById<OrderDTO>(_orderId),
                OrderDetailsList = (await _orderDetailsAPIService.Get<IEnumerable<OrderDetailsDTO>>(new OrderDetailsSearchRequest { OrderId = _orderId, Product = new ProductDTO() })).Select(x => new OrderDetailModel
                {
                    OrderDetail = x,
                    ProductPhotoUrl = $"{APIService._apiUrl}/Product/Photo/{x.ProductId}"
                }).ToList()
            };
        }
    }
}
