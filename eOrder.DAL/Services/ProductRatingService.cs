using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class ProductRatingService :
        BaseCRUDService<
            ProductRating,
            ProductRatingDTO,
            ProductRatingSearchRequest,
            ProductRatingRequest,
            ProductRatingRequest
            >
        , IProductRatingService
    {
        public ProductRatingService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }
    }
}
