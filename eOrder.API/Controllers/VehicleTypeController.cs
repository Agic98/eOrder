using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypeController : BaseController<
        VehicleType,
        VehicleTypeDTO,
        VehicleTypeSearchRequest,
        VehicleTypeRequest,
        VehicleTypeRequest
        >
    {
        public VehicleTypeController(IVehicleTypeService VehicleTypeService) :
            base(VehicleTypeService)
        {
        }
    }
}
