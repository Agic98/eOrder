using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : BaseController<
        Discount,
        DiscountDTO,
        DiscountSearchRequest,
        DiscountRequest,
        DiscountRequest
        >
    {
        public DiscountController(IDiscountService DiscountService) :
            base(DiscountService)
        {
        }
    }
}
