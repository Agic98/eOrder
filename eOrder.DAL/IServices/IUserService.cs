using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IUserService : 
        IBaseCRUDService<
            User,
            UserDTO,
            UserSearchRequest,
            UserRequest,
            UserRequest
            >
    {
        UserAuthDTO Authenticate(string username, string password);
    }
}
