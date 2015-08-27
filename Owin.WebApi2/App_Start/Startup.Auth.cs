using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

namespace Owin.WebApi2
{
    public partial class Startup
    {
        private void ConfigureAuth( IAppBuilder app, HttpConfiguration config )
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                CookieHttpOnly = true,
                CookieSecure = CookieSecureOption.SameAsRequest,
                SlidingExpiration = true,
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                CookieName = "authId"
            });
        }
    }
}
