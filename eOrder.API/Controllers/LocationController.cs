using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : BaseController<
        Location,
        LocationDTO,
        LocationSearchRequest,
        LocationRequest,
        LocationRequest
        >
    {
        public LocationController(ILocationService LocationService) :
            base(LocationService)
        {
        }
    }
}
