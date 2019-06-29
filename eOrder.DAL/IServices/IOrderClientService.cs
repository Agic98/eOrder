using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IOrderClientService : 
        IBaseCRUDService<
            Order,
            OrderDTO,
            OrderSearchRequest,
            OrderRequestClient,
            OrderRequestClient
            >
    {
    }
}
