using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IProductTagService : 
        IBaseCRUDService<
            ProductTag,
            ProductTagDTO,
            ProductTagSearchRequest,
            ProductTagRequest,
            ProductTagRequest
            >
    {
    }
}
