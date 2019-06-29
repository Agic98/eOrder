using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IOrganizationTypeService : 
        IBaseCRUDService<
            OrganizationType,
            OrganizationTypeDTO,
            OrganizationTypeSearchRequest,
            OrganizationTypeRequest,
            OrganizationTypeRequest
            >
    {
    }
}
