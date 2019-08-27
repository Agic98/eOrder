using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class ProductService :
        BaseCRUDService<
            Product,
            ProductDTO,
            ProductSearchRequest,
            ProductRequest,
            ProductRequest
            >
        , IProductService
    {
        public ProductService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }

        public override IEnumerable<ProductDTO> Get(ProductSearchRequest searchObject = null, Pagination pagination = null)
        {
            Query = Query
                .Where(x =>
                (searchObject.PriceFrom == 0 || x.Price >= searchObject.PriceFrom) &&
                (searchObject.PriceTo == 0 || x.Price <= searchObject.PriceTo) &&
                (string.IsNullOrEmpty(searchObject.Name) || x.Name == searchObject.Name));

            return base.Get(searchObject, pagination);
        }

        public double GetAverageProductPriceByOrganizationId(int organizationId)
        {
            return _dbContext.Products
                .Where(x => x.OrganizationId == organizationId)
                .Select(x => x.Price)
                .DefaultIfEmpty(0)
                .Average();
        }
    }
}
