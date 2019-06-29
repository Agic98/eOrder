using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
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

        public IEnumerable<ProductDTO> GetByUserIdForRecommendation(int userId)
        {
            var ratings = _dbContext.ProductRatings.Where(x => x.UserId == userId && x.Rating > 3).ToList();
            var data = new List<ProductDTO>();

            foreach (var item in ratings)
            {
                data.AddRange(GetSimilarProducts(item.ProductId));
            }

            if (data.Count < 5)
            {
                data.AddRange(_mapper.Map<IEnumerable<ProductDTO>>(_dbContext.Products.ToList()));
            }

            return data;
        }

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

        public List<ProductDTO> GetSimilarProducts(int productId)
        {
            var productRatingsDict = LoadProducts(productId);
            var ratingsForCurrentProduct = _dbContext.ProductRatings.Where(x => x.ProductId == productId).ToList();

            var recomendedProducts = new List<ProductDTO>();
            var commonRaings1 = new List<ProductRating>();
            var commonRaings2 = new List<ProductRating>();

            foreach (var item in productRatingsDict)
            {
                foreach (var rating in ratingsForCurrentProduct)
                {
                    if (item.Value.Where(x => x.UserId == rating.Id).Count() > 0)
                    {
                        commonRaings1.Add(rating);
                        commonRaings2.Add(item.Value.Where(x => x.UserId == rating.UserId).FirstOrDefault());
                    }
                }

                var simillarity = GetSimillarity(commonRaings1, commonRaings2);

                if (simillarity > 0.5)
                {
                    var product = _dbContext.Products.Where(x => x.Id == item.Key).FirstOrDefault();
                    if (product != null)
                    {
                        recomendedProducts.Add(_mapper.Map<ProductDTO>(product));
                    }
                }

                commonRaings1.Clear();
                commonRaings2.Clear();
            }


            return recomendedProducts;
        }

        private Dictionary<int, List<ProductRating>> LoadProducts(int productId)
        {
            var productRatingsDict = new Dictionary<int, List<ProductRating>>();
            var products = _dbContext.Products.Where(x => x.Id != productId && !x.IsDeleted).ToList();
            var ratings = new List<ProductRating>();

            foreach (var product in products)
            {
                ratings = _dbContext.ProductRatings.Where(x => x.ProductId == product.Id).ToList();
                if (ratings.Count > 0)
                {
                    productRatingsDict.Add(product.Id, ratings);
                }
            }
            return productRatingsDict;
        }

        private double GetSimillarity(List<ProductRating> productRatings1, List<ProductRating> productRatings2)
        {
            if(productRatings1.Count == 0 || productRatings2.Count == 0)
            {
                return 0;
            }

            double a = 0, b = 1, c = 1;


            for (int i = 0; i < productRatings1.Count; i++)
            {
                a = productRatings1[i].Rating * productRatings2[i].Rating;
                b = productRatings1[i].Rating * productRatings1[i].Rating;
                c = productRatings2[i].Rating * productRatings2[i].Rating;
            }

            b = Math.Sqrt(b);
            c = Math.Sqrt(c);

            double d = b * c;
            if (d == 0)
                return 0;

            return a / d;
        }
    }
}
