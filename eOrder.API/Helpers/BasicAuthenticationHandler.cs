using eOrder.CORE;
using eOrder.CORE.Helpers;
using eOrder.CORE.Requests;
using eOrder.DAL.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Helpers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserService _userService;
        private readonly IPersonService _personService;
        private readonly IDeliveryPersonService _deliveryPersonService;
        private readonly IOrganizationService _organizationService;
        private readonly Resources _resources;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            Resources resources,
            IUserService userService,
            IPersonService personService,
            IDeliveryPersonService deliveryPersonService,
            IOrganizationService organizationService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
            _personService = personService;
            _deliveryPersonService = deliveryPersonService;
            _organizationService = organizationService;

            _resources = resources;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail(_resources.MissingAuthorizationHeader);
            }

            UserAuthDTO user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = _userService.Authenticate(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail(_resources.InvalidAuthorizationHeader);
            }

            if (user == null)
            {
                return AuthenticateResult.Fail(_resources.InvalidUsernameOrPassword);
            }

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.Username)
            };

            foreach (var role in user.UserRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Role.Name));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }

        
    }
}
