using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface ITagService : 
        IBaseCRUDService<
            Tag,
            TagDTO,
            TagSearchRequest,
            TagRequest,
            TagRequest
            >
    {
    }
}
