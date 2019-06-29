using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;
using System.Linq;

namespace eOrder.DAL.Services
{
    public class UserRatingService :
        BaseCRUDService<
            UserRating,
            UserRatingDTO,
            UserRatingSearchRequest,
            UserRatingRequest,
            UserRatingRequest
            >
        , IUserRatingService
    {
        public UserRatingService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }

        public double GetByUserId(int userId)
        {
            return base.Get(new UserRatingSearchRequest() { UserToId = userId })
                .Select(x => x.Rating)
                .DefaultIfEmpty(0)
                .Average();
        }

        public int TotalNumberOfRatingByUserId(int userId)
        {
            return base.Get(new UserRatingSearchRequest { UserToId = userId }).Count();
        }
    }
}
