using AutoMapper;
using eOrder.CORE;
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
    public class UserService :
        BaseCRUDService<
            User,
            UserDTO,
            UserSearchRequest,
            UserRequest,
            UserRequest
            >
        , IUserService
    {
        public UserService(
            EOrderDbContext dbContext,
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }

        public UserAuthDTO Authenticate(string username, string password)
        {
            User user = _dbContext.Users
                .Where(x => x.Username == username)
                .FirstOrDefault();

            if (user == null)
            {
                return null;
            }

            password = Crypto.GetHashedPassword(password, user.PasswordSalt);

            if (user.PasswordHash != password)
            {
                return null;
            }

            var userDTO = _mapper.Map<UserAuthDTO>(user);

            var userRolesDTO = _dbContext.UserRoles
                .Include(x => x.Role)
                .Include(x => x.User)
                .Where(x => x.UserId == userDTO.Id)
                .ToList();

            userDTO.UserRoles = _mapper.Map<List<UserRoleDTO>>(userRolesDTO);

            return userDTO;
        }

        public override UserDTO Insert(UserRequest request)
        {
            var model = _mapper.Map<User>(request);

            if(string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password) || string.IsNullOrEmpty(request.PasswordConfirmed))
            {
                throw new UserException("Username or Password or PasswordConfirm is empty");
            }

            if (request.Password != request.PasswordConfirmed)
            {
                throw new UserException(_resources.PasswordsNotMatching);
            }

            model.PasswordSalt = Crypto.GenerateSalt();
            model.PasswordHash = Crypto.GetHashedPassword(request.Password, model.PasswordSalt);

            var result = _dbContext.Users.Add(model).Entity;
            _dbContext.SaveChanges();

            return _mapper.Map<UserDTO>(result);
        }
    }
}
