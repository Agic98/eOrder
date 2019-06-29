using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class OrderDetailsService :
        BaseCRUDService<
            OrderDetails,
            OrderDetailsDTO,
            OrderDetailsSearchRequest,
            OrderDetailsRequest,
            OrderDetailsRequest
            >
        , IOrderDetailsService
    {
        private IProductService _productService;

        public OrderDetailsService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources,
            IProductService productService) :
            base(dbContext, mapper, resources)
        {
            _productService = productService;
        }

        public override OrderDetailsDTO Insert(OrderDetailsRequest request)
        {
            var productDTO = _productService.GetById(request.ProductId);
            request.ProductPrice = productDTO.Price;

            return base.Insert(request);
        }

        public override OrderDetailsDTO Update(int id, OrderDetailsRequest request)
        {
            var productDTO = _productService.GetById(request.ProductId);
            request.ProductPrice = productDTO.Price;

            return base.Update(id, request);
        }
    }
}
