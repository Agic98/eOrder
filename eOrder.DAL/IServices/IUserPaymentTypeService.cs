using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IUserPaymentTypeService : 
        IBaseCRUDService<
            UserPaymentType,
            UserPaymentTypeDTO,
            UserPaymentTypeSearchRequest,
            UserPaymentTypeRequest,
            UserPaymentTypeRequest
            >
    {
    }
}
