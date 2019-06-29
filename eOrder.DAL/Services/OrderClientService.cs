using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class OrderClientService :
        BaseCRUDService<
            Order,
            OrderDTO,
            OrderSearchRequest,
            OrderRequestClient,
            OrderRequestClient
            >
        , IOrderClientService
    {
        private IOrderDetailsService _orderDetailsService;

        public OrderClientService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources,
            IOrderDetailsService orderDetailsService) :
            base(dbContext, mapper, resources)
        {
            _orderDetailsService = orderDetailsService;
        }

        public override IEnumerable<OrderDTO> Get(OrderSearchRequest searchObject = null, Pagination pagination = null)
        {
            searchObject.Organization = new OrganizationDTO();
            var orders = base.Get(searchObject, pagination);

            foreach (var order in orders)
            {
                var total = _orderDetailsService.Get(new OrderDetailsSearchRequest
                {
                    OrderId = order.Id
                }).Sum(x => x.ProductPrice * x.Amount);

                order.Total = (double)total;
                order.TotalWithTax = order.Total * (1 - order.Organization.TaxRate);
            }

            return orders;
        }

        public override OrderDTO Update(int id, OrderRequestClient request)
        {
            request.Total = _orderDetailsService.Get(new OrderDetailsSearchRequest { OrderId = id })
                .Select(x => new { Total = x.ProductPrice * x.Amount })
                .Sum(x => x.Total);

            return base.Update(id, request);
        }
    }
}
