using System.Web.Http;
using Owin.WebApi2.Services;

namespace Owin.WebApi2.Controllers.v1
{
    [RoutePrefix("api/v1/helloworld/d")]
    public class DependentController : ApiController
    {
        private readonly IHelloWorldService _helloWorldService;
        public DependentController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        [Route("hello")]
        public IHttpActionResult Hello()
        {
            return Json(_helloWorldService.Hello());
        }

        [HttpGet]
        [Authorize]
        [Route("")]
        public IHttpActionResult HelloWorld()
        {
            return Json(_helloWorldService.HelloWorld());
        }
    }
}
