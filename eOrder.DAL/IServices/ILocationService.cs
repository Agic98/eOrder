using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface ILocationService : 
        IBaseCRUDService<
            Location,
            LocationDTO,
            LocationSearchRequest,
            LocationRequest,
            LocationRequest
            >
    {
    }
}
