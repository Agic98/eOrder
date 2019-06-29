using AutoMapper;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace eOrder.WebApi.Helpers
{
    public static class Authentication
    {
        public static UserDTO CurrentUser(this HttpContext httpContext)
        {
            var _userService = httpContext.RequestServices.GetRequiredService<IUserService>();
            var _mapper = httpContext.RequestServices.GetRequiredService<IMapper>();

            UserAuthDTO userAuthDTO = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(httpContext.Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                userAuthDTO = _userService.Authenticate(username, password);
            }
            catch
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            if (userAuthDTO == null)
            {
                throw new UnauthorizedAccessException("Invalid Username or Password");
            }

            return _userService.GetById(userAuthDTO.Id);
        }

        public static PersonDTO CurrentPerson(this HttpContext httpContext)
        {
            var userDTO = httpContext.CurrentUser();
            var _personService = httpContext.RequestServices.GetRequiredService<IPersonService>();
            return _personService.Get(new PersonSearchRequest { UserId = userDTO.Id, User = new UserDTO()}).FirstOrDefault();
        }

        public static DeliveryPersonDTO CurrentDeliveryPerson(this HttpContext httpContext)
        {
            var personDTO = httpContext.CurrentPerson();
            var _deliveryPersonService = httpContext.RequestServices.GetRequiredService<IDeliveryPersonService>();
            return _deliveryPersonService.Get(new DeliveryPersonSearchRequest { PersonId = personDTO.Id, Person = new PersonDTO { User = new UserDTO() } }).FirstOrDefault();
        }

        public static OrganizationDTO CurrentOrganization(this HttpContext httpContext)
        {
            var userDTO = httpContext.CurrentUser();
            var _organizationService = httpContext.RequestServices.GetRequiredService<IOrganizationService>();
            return _organizationService.Get(new OrganizationSearchRequest { UserId = userDTO.Id, User = new UserDTO() }).FirstOrDefault();
        }
    }
}
