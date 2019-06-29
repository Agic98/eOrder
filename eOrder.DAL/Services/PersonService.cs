using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Constants;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using System;
using System.Linq;

namespace eOrder.DAL.Services
{
    public class PersonService :
        BaseCRUDService<
            Person,
            PersonDTO,
            PersonSearchRequest,
            PersonRequest,
            PersonRequest
            >
        , IPersonService
    {
        private IUserService _userService;
        private IUserRoleService _userRoleService;
        private IRoleService _roleService;

        public PersonService(
            EOrderDbContext dbContext,
            IMapper mapper,
            Resources resources,
            IUserService userService,
            IUserRoleService userRoleService,
            IRoleService roleService) :
            base(dbContext, mapper, resources)
        {
            _userService = userService;
            _userRoleService = userRoleService;
            _roleService = roleService;
        }

        public override PersonDTO Insert(PersonRequest request)
        {
            if (request.User == null)
                throw new UserException("User data is required");

            try
            {
                var newUser = _userService.Insert(request.User);
                request.UserId = newUser.Id;

                var clientRoleId = _roleService.Get(new RoleSearchRequest { Name = UserType.Client })?.FirstOrDefault()?.Id;
                if (!clientRoleId.HasValue)
                    throw new Exception();

                _userRoleService.Insert(new UserRoleRequest
                {
                    UserId = newUser.Id,
                    RoleId = clientRoleId.Value
                });
            }
            catch (Exception e)
            {
                throw e;
            }

            return base.Insert(request);
        }
    }
}
