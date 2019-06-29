using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : BaseController<
        Currency,
        CurrencyDTO,
        CurrencySearchRequest,
        CurrencyRequest,
        CurrencyRequest
        >
    {
        public CurrencyController(ICurrencyService CurrencyService) :
            base(CurrencyService)
        {
        }
    }
}
