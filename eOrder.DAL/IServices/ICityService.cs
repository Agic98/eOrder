using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface ICityService : 
        IBaseCRUDService<
            City,
            CityDTO,
            CitySearchRequest,
            CityRequest,
            CityRequest
            >
    {
    }
}
