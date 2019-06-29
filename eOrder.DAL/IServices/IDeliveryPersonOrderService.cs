using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IDeliveryPersonOrderService :
        IBaseCRUDService<
            DeliveryPersonOrder,
            DeliveryPersonOrderDTO,
            DeliveryPersonOrderSearchRequest,
            DeliveryPersonOrderRequest,
            DeliveryPersonOrderRequest
            >
    {
    }
}
