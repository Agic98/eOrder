using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingHourController : BaseController<
        WorkingHour,
        WorkingHourDTO,
        WorkingHourSearchRequest,
        WorkingHourRequest,
        WorkingHourRequest
        >
    {
        public WorkingHourController(IWorkingHourService WorkingHourService) :
            base(WorkingHourService)
        {
        }
    }
}
