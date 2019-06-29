using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryPersonController : BaseController<
        DeliveryPerson,
        DeliveryPersonDTO,
        DeliveryPersonSearchRequest,
        DeliveryPersonRequest,
        DeliveryPersonRequest
        >
    {
        public DeliveryPersonController(IDeliveryPersonService DeliveryPersonService) :
            base(DeliveryPersonService)
        {
        }
    }
}
