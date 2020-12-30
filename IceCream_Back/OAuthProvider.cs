using System;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Owin.Security.OAuth;
using Bl;
using Dto;

namespace IceCream_Back
{
    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            var email = context.UserName;
            var password = context.Password;
            UserDto user = UserBl.ValidateUser(email, password);

            if (user != null)
            {
                 identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                identity.AddClaim(new Claim("username", user.email));

                IDictionary<string, string> data = new Dictionary<string, string>
                {
                 { "userId", user.userId.ToString() }
                };
                AuthenticationProperties properties = new AuthenticationProperties(data);
                Microsoft.Owin.Security.AuthenticationTicket ticket = new Microsoft.Owin.Security.AuthenticationTicket(identity, properties);
                context.Validated(ticket);
            }
            else
            {
                context.SetError("invalid_grant", "please provide different username or password");
                return;
            }


        }
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

    }
}