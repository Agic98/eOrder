using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : BaseController<
        OrderDetails,
        OrderDetailsDTO,
        OrderDetailsSearchRequest,
        OrderDetailsRequest,
        OrderDetailsRequest
        >
    {
        public OrderDetailsController(
            IOrderDetailsService OrderDetailsService) :
            base(OrderDetailsService)
        {}
    }
}
