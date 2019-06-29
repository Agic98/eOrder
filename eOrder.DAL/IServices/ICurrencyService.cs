using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface ICurrencyService : 
        IBaseCRUDService<
            Currency,
            CurrencyDTO,
            CurrencySearchRequest,
            CurrencyRequest,
            CurrencyRequest
            >
    {
    }
}
