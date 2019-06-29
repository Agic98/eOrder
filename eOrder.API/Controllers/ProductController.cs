using System.Collections.Generic;
using System.Linq;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using eOrder.WebApi.Controllers;
using eOrder.WebApi.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<
        Product,
        ProductDTO,
        ProductSearchRequest,
        ProductRequest,
        ProductRequest
        >
    {
        private IProductService _productService;

        public ProductController(IProductService ProductService) :
            base(ProductService)
        {
            _productService = ProductService;
        }

        public override IEnumerable<ProductDTO> Get([FromQuery] ProductSearchRequest searchObject = null, [FromQuery] Pagination pagination = null)
        {
            if (HttpContext.CurrentOrganization() != null)
            {
                searchObject.OrganizationId = HttpContext.CurrentOrganization().Id;
            }

            var data = new List<ProductDTO>();

            if(searchObject == null && HttpContext.CurrentPerson() != null && HttpContext.CurrentDeliveryPerson() == null)
            {
                data = _productService.GetByUserIdForRecommendation(HttpContext.CurrentUser().Id).ToList();
            }
            else if(data.Count == 0)
            {
                base.Get(searchObject).ToList();
            }
            else
            {
                base.Get(searchObject).ToList();
            }

            return data;
        }

        public IEnumerable<ProductDTO> Recommend()
        {
            var currentUser = HttpContext.CurrentUser();
            return _productService.GetByUserIdForRecommendation(currentUser.Id);
        }

        [HttpGet("Photo/{id}")]
        [AllowAnonymous]
        public IActionResult GetPhoto(int id)
        {
            var productDTO = base.Get(id);
            return File(productDTO.Photo, "image/jpeg");
        }

        public override ProductDTO Post([FromBody] ProductRequest request)
        {
            request.OrganizationId = HttpContext.CurrentOrganization().Id;
            return base.Post(request);
        }

        public override ProductDTO Put(int id, [FromBody] ProductRequest request)
        {
            request.OrganizationId = HttpContext.CurrentOrganization().Id;
            return base.Put(id, request);
        }
    }
}
