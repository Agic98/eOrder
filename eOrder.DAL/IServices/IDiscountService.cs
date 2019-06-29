using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IDiscountService :
        IBaseCRUDService<
            Discount,
            DiscountDTO,
            DiscountSearchRequest,
            DiscountRequest,
            DiscountRequest
            >
    {
    }
}
