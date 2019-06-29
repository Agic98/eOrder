using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IProductRatingService : 
        IBaseCRUDService<
            ProductRating,
            ProductRatingDTO,
            ProductRatingSearchRequest,
            ProductRatingRequest,
            ProductRatingRequest
            >
    {
    }
}
