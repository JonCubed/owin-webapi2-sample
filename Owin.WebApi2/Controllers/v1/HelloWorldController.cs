using System;
using System.Web.Http;

namespace Owin.WebApi2.Controllers.v1
{
    [RoutePrefix("api/v1/helloworld")]
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult HelloWorld()
        {
            return Json("Hello World! " + DateTime.Now);
        }
    }
}
