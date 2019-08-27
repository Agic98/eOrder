using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using eOrder.WebApi.Helpers;
using GeoCoordinatePortable;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : BaseController<
        Organization,
        OrganizationDTO,
        OrganizationSearchRequest,
        OrganizationRequest,
        OrganizationRequest
        >
    {
        private IUserRatingService _userRatingService;
        private IProductService _productService;

        public OrganizationController(
            IOrganizationService OrganizationService,
            IUserRatingService userRatingService,
            IProductService productService) :
            base(OrganizationService)
        {
            _userRatingService = userRatingService;
            _productService = productService;
        }

        public override OrganizationDTO Get(int id)
        {
            var organization = base.Get(id);

            var currentUser = HttpContext.CurrentUser();
            var currentUserCoord = new GeoCoordinate(currentUser.LocationLatitude, currentUser.LocationLongitude);

            #region location distance from current user
            var organizationCoord = new GeoCoordinate(organization.User.LocationLatitude, organization.User.LocationLongitude);

            //GetDistanceTo -> distance in meters
            //DistanceFromCurrentUser -> distance in kilometers
            organization.DistanceFromCurrentUser = Math.Round(organizationCoord.GetDistanceTo(currentUserCoord) / 1000, 1);
            #endregion

            #region user rating
            organization.AverageRating = Math.Round(_userRatingService.GetByUserId(organization.Id), 1);
            organization.TotalNumberOfRatings = _userRatingService.TotalNumberOfRatingByUserId(organization.Id);
            #endregion

            #region average price
            organization.AverageProductPrice = _productService.GetAverageProductPriceByOrganizationId(organization.Id);
            #endregion

            return organization;
        }

        public override IEnumerable<OrganizationDTO> Get([FromQuery] OrganizationSearchRequest searchObject = null, [FromQuery] Pagination pagination = null)
        {
            if (searchObject.User == null)
                searchObject.User = new UserDTO();

            var organizations = base.Get(searchObject, pagination);

            var currentUser = HttpContext.CurrentUser();
            var currentUserCoord = new GeoCoordinate(currentUser.LocationLatitude, currentUser.LocationLongitude);

            foreach (var organization in organizations)
            {
                #region location distance from current user
                var organizationCoord = new GeoCoordinate(organization.User.LocationLatitude, organization.User.LocationLongitude);

                //GetDistanceTo -> distance in meters
                //DistanceFromCurrentUser -> distance in kilometers
                organization.DistanceFromCurrentUser = Math.Round(organizationCoord.GetDistanceTo(currentUserCoord) / 1000, 1);
                #endregion

                #region user rating
                organization.AverageRating = Math.Round(_userRatingService.GetByUserId(organization.Id), 1);
                organization.TotalNumberOfRatings = _userRatingService.TotalNumberOfRatingByUserId(organization.Id);
                #endregion

                #region average price
                organization.AverageProductPrice = _productService.GetAverageProductPriceByOrganizationId(organization.Id);
                #endregion
            }

            organizations = organizations.OrderBy(x => x.AverageProductPrice);

            organizations = organizations.Where(x => searchObject.AverageProductPriceMax == 0 || x.AverageProductPrice <= searchObject.AverageProductPriceMax).ToList();
            organizations = organizations.Where(x => searchObject.RatingMin == 0 || x.AverageRating >= searchObject.RatingMin).ToList();
            organizations = organizations.Where(x => searchObject.DistanceKilometers == 0 || x.DistanceFromCurrentUser <= searchObject.DistanceKilometers).ToList();
            organizations = organizations.Where(x => searchObject.DeliveryTimeMinutesMax == 0 || x.DeliveryTimeCalculated <= searchObject.DeliveryTimeMinutesMax).ToList();

            return organizations;
        }

        [HttpGet("ProfilePhoto/{id}")]
        [AllowAnonymous]
        public IActionResult GetProfilePhoto(int id)
        {
            var organizationDTO = base.Get(id);
            return File(organizationDTO.ProfilePhoto, "image/jpeg");
        }

    }
}
