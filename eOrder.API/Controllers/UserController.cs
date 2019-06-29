using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<
        User,
        UserDTO,
        UserSearchRequest,
        UserRequest,
        UserRequest
        >
    {
        public UserController(IUserService userService) :
            base(userService)
        {
        }
    }
}
