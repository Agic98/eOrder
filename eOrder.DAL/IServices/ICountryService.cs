using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface ICountryService : 
        IBaseCRUDService<
            Country,
            CountryDTO,
            CountrySearchRequest,
            CountryRequest,
            CountryRequest
            >
    {
    }
}
