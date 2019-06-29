using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using System.Collections.Generic;

namespace eOrder.DAL.IServices
{
    public interface IProductService : 
        IBaseCRUDService<
            Product,
            ProductDTO,
            ProductSearchRequest,
            ProductRequest,
            ProductRequest
            >
    {
        double GetAverageProductPriceByOrganizationId(int organizationId);
        IEnumerable<ProductDTO> GetByUserIdForRecommendation(int userId);
    }
}
