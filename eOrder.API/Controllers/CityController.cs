using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : BaseController<
        City,
        CityDTO,
        CitySearchRequest,
        CityRequest,
        CityRequest
        >
    {
        public CityController(ICityService CityService) :
            base(CityService)
        {
        }
    }
}
