using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IUserRatingService :
        IBaseCRUDService<
            UserRating,
            UserRatingDTO,
            UserRatingSearchRequest,
            UserRatingRequest,
            UserRatingRequest
            >
    {
        double GetByUserId(int userId);
        int TotalNumberOfRatingByUserId(int userId);
    }
}
