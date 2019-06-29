using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Constants;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eOrder.DAL.Services
{
    public class OrganizationService :
        BaseCRUDService<
            Organization,
            OrganizationDTO,
            OrganizationSearchRequest,
            OrganizationRequest,
            OrganizationRequest
            >
        , IOrganizationService
    {
        private IUserService _userService;
        private IUserRoleService _userRoleService;
        private IRoleService _roleService;

        public OrganizationService(
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

        public override OrganizationDTO Insert(OrganizationRequest request)
        {
            var userDTO = _userService.Insert(request.User);

            var organization = _mapper.Map<Organization>(request);
            organization.UserId = userDTO.Id;

            _dbContext.Organizations.Add(organization);
            _dbContext.SaveChanges();

            var organizationRoleDTO = _roleService.Get(new RoleSearchRequest
            {
                Name = UserType.Organization
            }).FirstOrDefault();

            _userRoleService.Insert(new UserRoleRequest
            {
                RoleId = organizationRoleDTO.Id,
                UserId = userDTO.Id
            });

            return _mapper.Map<OrganizationDTO>(organization);
        }

        public override OrganizationDTO GetById(object id)
        {
            //var model = _dbContext.Organizations
            //    .Where(x => id.Equals(x.Id))
            //    .Include(x => x.User)
            //    .Include(x => x.OrganizationType)
            //    .FirstOrDefault();

            Query = Query
                .Include(x => x.User)
                .Include(x => x.OrganizationType);

            var model = base.GetById(id);

            return _mapper.Map<OrganizationDTO>(model);
        }
    }
}
