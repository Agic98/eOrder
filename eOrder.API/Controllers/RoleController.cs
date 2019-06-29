using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController<
        Role,
        RoleDTO,
        RoleSearchRequest,
        RoleRequest,
        RoleRequest
        >
    {
        public RoleController(IRoleService RoleService) :
            base(RoleService)
        {
        }
    }
}
