using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController<
        Country,
        CountryDTO,
        CountrySearchRequest,
        CountryRequest,
        CountryRequest
        >
    {
        public CountryController(ICountryService CountryService) :
            base(CountryService)
        {
        }
    }
}
