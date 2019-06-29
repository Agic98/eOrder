using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IOrganizationService :
        IBaseCRUDService<
            Organization,
            OrganizationDTO,
            OrganizationSearchRequest,
            OrganizationRequest,
            OrganizationRequest
            >
    {
    }
}
