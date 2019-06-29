using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IDeliveryPersonService :
        IBaseCRUDService<
            DeliveryPerson,
            DeliveryPersonDTO,
            DeliveryPersonSearchRequest,
            DeliveryPersonRequest,
            DeliveryPersonRequest
            >
    {
    }
}
