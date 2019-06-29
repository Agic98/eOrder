using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface ICategoryService : 
        IBaseCRUDService<
            Category,
            CategoryDTO,
            CategorySearchRequest,
            CategoryRequest,
            CategoryRequest
            >
    {
    }
}
