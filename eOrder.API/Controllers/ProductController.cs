using System.Collections.Generic;
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
        public ProductController(IProductService ProductService) :
            base(ProductService)
        {
        }

        public override IEnumerable<ProductDTO> Get([FromQuery] ProductSearchRequest searchObject = null, [FromQuery] Pagination pagination = null)
        {
            if (HttpContext.CurrentOrganization() != null)
            {
                searchObject.OrganizationId = HttpContext.CurrentOrganization().Id;
            }
            return base.Get(searchObject, pagination);
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
