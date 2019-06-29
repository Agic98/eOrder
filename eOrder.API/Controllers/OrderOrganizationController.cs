using System.Collections.Generic;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using eOrder.WebApi.Helpers;
using eProdaja.WebAPI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OrderOrganizationController : BaseController<
        Order,
        OrderDTO,
        OrderSearchRequest,
        OrderRequestOrganization,
        OrderRequestOrganization
        >
    {
        public OrderOrganizationController(IOrderOrganizationService OrderService) :
            base(OrderService)
        {
        }

        public override IEnumerable<OrderDTO> Get([FromQuery] OrderSearchRequest searchObject = null, [FromQuery] Pagination pagination = null)
        {
            if (searchObject == null)
                searchObject = new OrderSearchRequest();

            searchObject.OrganizationId = HttpContext.CurrentOrganization().Id;

            var data = base.Get(searchObject, pagination);
            return data;
        }
    }
}
