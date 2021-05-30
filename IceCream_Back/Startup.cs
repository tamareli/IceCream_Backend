using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(IceCream_Back.Startup))]

namespace IceCream_Back
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888   
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            var myprovider = new OAuthProvider();
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = myprovider
            };
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
        }

    }
}
