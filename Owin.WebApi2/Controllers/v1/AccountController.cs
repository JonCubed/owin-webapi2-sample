using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace Owin.WebApi2.Controllers.v1
{
    [RoutePrefix("api/v1/account")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login()
        {
            var claims = new List<Claim>() {
                new Claim(ClaimTypes.Name, "TestUser"),
                new Claim(ClaimTypes.NameIdentifier, "1")
            };
            var identity = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignIn(identity);
            return Ok();
        }

        [HttpPost]
        [Route("logout")]
        public IHttpActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return Ok();
        }
    }
}
