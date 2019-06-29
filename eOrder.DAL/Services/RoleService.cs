using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Helpers;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using System.Collections.Generic;
using System.Linq;

namespace eOrder.DAL.Services
{
    public class RoleService :
        BaseCRUDService<
            Role,
            RoleDTO,
            RoleSearchRequest,
            RoleRequest,
            RoleRequest
            >
        , IRoleService
    {
        public RoleService(
            EOrderDbContext dbContext,
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }

        public override IEnumerable<RoleDTO> Get(RoleSearchRequest searchObject = null, Pagination pagination = null)
        {
            var data = base.Get(searchObject, pagination);

            if (searchObject.Username != null && searchObject.Password != null)
            {
                if (!searchObject.Username.Equals(ObjectExtension.GetDefaultTypeValue(searchObject.Username.GetType())) &&
               !searchObject.Password.Equals(ObjectExtension.GetDefaultTypeValue(searchObject.Password.GetType())))
                {
                    var result = _dbContext.UserRoles
                    .Where(x => data.Select(y => y.Id).Contains(x.RoleId) &&
                                x.User.Username == searchObject.Username &&
                                x.User.PasswordHash == Crypto.GetHashedPassword(searchObject.Password, x.User.PasswordSalt))
                    .Select(x => x.Role)
                    .ToList();

                    return _mapper.Map<IEnumerable<RoleDTO>>(result);
                }
            }

            return data;
        }

    }
}
