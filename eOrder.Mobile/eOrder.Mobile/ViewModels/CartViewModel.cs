using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using eOrder.Mobile.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        APIService _ordersService { get; set; } = new APIService("OrderClient");
        APIService _orderDetailsService { get; set; } = new APIService("OrderDetails");
        public ObservableCollection<OrderDTO> CartOrders { get; set; } = new ObservableCollection<OrderDTO>();
        ICommand InitCommand { get; set; }
         
        string _additionalDescription = string.Empty;
        public string AdditionalDescription
        {
            get { return _additionalDescription; }
            set { SetProperty(ref _additionalDescription, value); }
        }

        bool _isEmpty;
        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { SetProperty(ref _isEmpty, value); }
        }

        public CartViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            IsEmpty = false;

            var orders = await _ordersService.Get<IEnumerable<OrderDTO>>(new OrderSearchRequest
            {
                OrderStatus = OrderStatus.NotInitiated,
                Organization = new OrganizationDTO()
            });

            Cart.CompanyOrderCombination.Clear();
            foreach (var order in orders)
            {
                Cart.CompanyOrderCombination.Add(order.OrganizationId.GetValueOrDefault(), order.Id);
            }

            CartOrders.Clear();
            foreach (var order in orders)
            {
                var orderDetails = await _orderDetailsService.Get<IEnumerable<OrderDetailsDTO>>(new OrderDetailsSearchRequest { OrderId = order.Id, Product = new ProductDTO() });
                CartOrders.Add(order);
            }

            IsEmpty = CartOrders.Count == 0;
        }

        //public async Task Init()
        //{
        //    var orders = await _ordersService.Get<IEnumerable<OrderDTO>>(new OrderSearchRequest
        //    {
        //        OrderStatus = OrderStatus.NotInitiated,
        //        Organization = new OrganizationDTO()
        //    });

        //    Cart.CompanyOrderCombination.Clear();
        //    foreach (var order in orders)
        //    {
        //        Cart.CompanyOrderCombination.Add(order.OrganizationId.GetValueOrDefault(), order.Id);
        //    }

        //    CartOrders.Clear();
        //    foreach (var order in orders)
        //    {
        //        var orderDetails = await _orderDetailsService.Get<IEnumerable<OrderDetailsDTO>>(new OrderDetailsSearchRequest { OrderId = order.Id, Product = new ProductDTO() });
        //        CartOrders.Add(new OrderModel
        //        {
        //            Order = order,
        //            OrderDetailsList = orderDetails.Select(x => new OrderDetailModel
        //            {
        //                OrderDetail = x,
        //                ProductPhotoUrl = $"{APIService._apiUrl}/Product/Photo/{x.ProductId}"
        //            }).ToList()
        //        });
        //    }
        //}

        public async Task InitiateOrder(int orderId)
        {
            var orderDTO = await _ordersService.GetById<OrderDTO>(orderId);
            if (orderDTO != null)
            {
                await _ordersService.Update<OrderDTO>(orderId, new OrderRequestClient
                {
                    ClientId = orderDTO.ClientId,
                    LocationId = orderDTO.LocationId,
                    OrderStatus = OrderStatus.Pending,
                    AdditionalDescription = AdditionalDescription,
                    OrderType = orderDTO.OrderType,
                    OrganizationId = orderDTO.OrganizationId,
                    PaymentType = orderDTO.PaymentType
                });

                await Application.Current.MainPage.DisplayAlert("Success", "Successfully created order.", "OK");

                await Init();
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Error", "There was an error while creating the order, please try again.", "OK");
        }
    }

}
