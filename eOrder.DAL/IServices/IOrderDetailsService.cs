using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IOrderDetailsService : 
        IBaseCRUDService<
            OrderDetails,
            OrderDetailsDTO,
            OrderDetailsSearchRequest,
            OrderDetailsRequest,
            OrderDetailsRequest
            >
    {
    }
}
