using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IPersonService : 
        IBaseCRUDService<
            Person,
            PersonDTO,
            PersonSearchRequest,
            PersonRequest,
            PersonRequest
            >
    {
    }
}
