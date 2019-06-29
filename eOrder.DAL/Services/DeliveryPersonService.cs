using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Constants;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;
using System.Linq;

namespace eOrder.DAL.Services
{
    public class DeliveryPersonService :
        BaseCRUDService<
            DeliveryPerson,
            DeliveryPersonDTO,
            DeliveryPersonSearchRequest,
            DeliveryPersonRequest,
            DeliveryPersonRequest
            >
        , IDeliveryPersonService
    {
        private IUserRoleService _userRoleService;
        private IRoleService _roleService;

        public DeliveryPersonService(
            EOrderDbContext dbContext,
            IMapper mapper,
            IUserRoleService userRoleService,
            IRoleService roleService,
            Resources resources) :
            base(dbContext, mapper, resources)
        {
            _userRoleService = userRoleService;
            _roleService = roleService;
        }

        public override DeliveryPersonDTO Insert(DeliveryPersonRequest request)
        {
            var model = base.Insert(request);

            _userRoleService.Insert(new UserRoleRequest
            {
                UserId = model.Id,
                RoleId = _roleService.Get(new RoleSearchRequest
                {
                    Name = UserType.DeliveryPerson
                }).First().Id
            });

            return model;
        }
    }
}
