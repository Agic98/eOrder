using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryPersonOrderController : BaseController<
        DeliveryPersonOrder,
        DeliveryPersonOrderDTO,
        DeliveryPersonOrderSearchRequest,
        DeliveryPersonOrderRequest,
        DeliveryPersonOrderRequest
        >
    {
        public DeliveryPersonOrderController(IDeliveryPersonOrderService DeliveryPersonOrderService) :
            base(DeliveryPersonOrderService)
        {
        }
    }
}
