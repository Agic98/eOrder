using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : BaseController<
        Person,
        PersonDTO,
        PersonSearchRequest,
        PersonRequest,
        PersonRequest
        >
    {
        public PersonController(IPersonService PersonService) :
            base(PersonService)
        {
        }
    }
}
