using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IOrderOrganizationService : 
        IBaseCRUDService<
            Order,
            OrderDTO,
            OrderSearchRequest,
            OrderRequestOrganization,
            OrderRequestOrganization
            >
    {
    }
}
