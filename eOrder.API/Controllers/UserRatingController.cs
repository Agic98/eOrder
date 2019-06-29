using System.Collections.Generic;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using eOrder.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRatingController : BaseController<
        UserRating,
        UserRatingDTO,
        UserRatingSearchRequest,
        UserRatingRequest,
        UserRatingRequest
        >
    {
        public UserRatingController(IUserRatingService UserRatingService) :
            base(UserRatingService)
        {
        }

        public override UserRatingDTO Post([FromBody] UserRatingRequest request)
        {
            request.UserFromId = HttpContext.CurrentUser().Id;
            return base.Post(request);
        }

        public override UserRatingDTO Put(int id, [FromBody] UserRatingRequest request)
        {
            request.UserFromId = HttpContext.CurrentUser().Id;
            return base.Put(id, request);   
        }
    }
}
