using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IOrganizationImageService : 
        IBaseCRUDService<
            OrganizationImage,
            OrganizationImageDTO,
            OrganizationImageSearchRequest,
            OrganizationImageRequest,
            OrganizationImageRequest
            >
    {
    }
}
