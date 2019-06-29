using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationTypeController : BaseController<
        OrganizationType,
        OrganizationTypeDTO,
        OrganizationTypeSearchRequest,
        OrganizationTypeRequest,
        OrganizationTypeRequest
        >
    {
        public OrganizationTypeController(IOrganizationTypeService OrganizationTypeService) :
            base(OrganizationTypeService)
        {
        }
    }
}
