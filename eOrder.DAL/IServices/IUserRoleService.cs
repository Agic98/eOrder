using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IUserRoleService : 
        IBaseCRUDService<
            UserRole,
            UserRoleDTO,
            UserRoleSearchRequest,
            UserRoleRequest,
            UserRoleRequest
            >
    {
    }
}
