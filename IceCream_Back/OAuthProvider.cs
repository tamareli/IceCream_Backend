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
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.userId.ToString()));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "אימייל או סיסמה שגויים");
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