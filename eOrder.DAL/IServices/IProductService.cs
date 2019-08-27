using eOrder.CORE.Models;
using eOrder.CORE.Requests;

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
    }
}
