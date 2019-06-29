using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IRoleService : 
        IBaseCRUDService<
            Role,
            RoleDTO,
            RoleSearchRequest,
            RoleRequest,
            RoleRequest
            >
    {
    }
}
