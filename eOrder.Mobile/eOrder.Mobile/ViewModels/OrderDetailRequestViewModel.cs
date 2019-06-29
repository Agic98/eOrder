using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using eOrder.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class OrderDetailRequestViewModel : BaseViewModel
    {
        private readonly APIService _orderDetailsService = new APIService("OrderDetails");
        private readonly APIService _orderService = new APIService("OrderClient");
        private readonly APIService _productService = new APIService("Product");

        public ICommand InitCommand { get; set; }

        public OrderDetailRequestViewModel() { }

        public OrderDetailRequestViewModel(int? orderDetailId, int? productId)
        {
            OrderDetailId = orderDetailId.GetValueOrDefault();
            ProductId = productId.GetValueOrDefault();
            InitCommand = new Command(async () => await Init());
        }

        int _orderDetailId;
        public int OrderDetailId
        {
            get { return _orderDetailId; }
            set { SetProperty(ref _orderDetailId, value); }
        }

        int _orderId;
        public int OrderId
        {
            get { return _orderId; }
            set { SetProperty(ref _orderId, value); }
        }

        int _productId;
        public int ProductId
        {
            get { return _productId; }
            set { SetProperty(ref _productId, value); }
        }

        ProductDTO _product;
        public ProductDTO Product
        {
            get { return _product; }
            set
            {
                SetProperty(ref _product, value);
                Total = _product.Price * Amount;
            }
        }

        int _amount = 1;
        public int Amount
        {
            get { return _amount; }
            set
            {
                SetProperty(ref _amount, value);
                Total = Math.Round((Product?.Price ?? 1) * _amount, 2);
            }
        }

        double _total;
        public double Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        string _additionalDescription;
        public string AdditionalDescription
        {
            get { return _additionalDescription; }
            set { SetProperty(ref _additionalDescription, value); }
        }

        private async Task<int> CreateOrGetOrderId(int organizationId)
        {
            var orderId = 0;
            //Check if there is localy an orderId
            Cart.CompanyOrderCombination.TryGetValue(organizationId, out orderId);

            if (orderId == 0)
            {
                //Check if there is exsisting notInitiated order in the database - ping api
                var orderNotInitiatedDTO = (await _orderService.Get<IEnumerable<OrderDTO>>(new OrderSearchRequest
                {
                    OrganizationId = organizationId,
                    OrderStatus = OrderStatus.NotInitiated
                }))?.FirstOrDefault();

                if(orderNotInitiatedDTO == null)
                {
                    //Create new order
                    var newOrderNotInitiated = await _orderService.Insert<OrderDTO>(new OrderRequestClient
                    {
                        OrganizationId = organizationId,
                        OrderStatus = OrderStatus.NotInitiated
                    });

                    orderId = newOrderNotInitiated.Id;
                }
                else
                {
                    orderId = orderNotInitiatedDTO.Id;
                }
                
                Cart.CompanyOrderCombination.Add(organizationId, orderId);
            }

            return orderId;
        }

        public async Task Init()
        {
            if (OrderDetailId != 0)
            {
                //For editing exsisting item

                var orderDetailDTO = (await _orderDetailsService.Get<IEnumerable<OrderDetailsDTO>>(new OrderDetailsSearchRequest { Id = OrderDetailId, Product = new ProductDTO() })).FirstOrDefault();
                if (orderDetailDTO != null)
                {
                    OrderId = orderDetailDTO.OrderId;
                    ProductId = orderDetailDTO.ProductId.GetValueOrDefault();
                    Product = orderDetailDTO.Product;
                    Amount = orderDetailDTO.Amount;
                    AdditionalDescription = orderDetailDTO.AdditionalDescription;
                }
            }
            else
            {
                //For adding a new item
                var productDTO = await _productService.GetById<ProductDTO>(ProductId);
                if (productDTO != null)
                {
                    OrderId = await CreateOrGetOrderId(productDTO.OrganizationId);
                    Product = productDTO;
                }
            }
        }

        public async Task<bool> Save()
        {
            if (OrderDetailId == 0)
            {
                await _orderDetailsService.Insert<OrderDetailsDTO>(new OrderDetailsRequest
                {
                    OrderId = OrderId,
                    ProductId = ProductId,
                    Amount = Amount,
                    AdditionalDescription = AdditionalDescription
                });
            }
            else
            {
                await _orderDetailsService.Update<OrderDetailsDTO>(OrderDetailId, new OrderDetailsRequest
                {
                    OrderId = OrderId,
                    ProductId = ProductId,
                    Amount = Amount,
                    AdditionalDescription = AdditionalDescription
                });
            }

            return true;
        }
    }
}
