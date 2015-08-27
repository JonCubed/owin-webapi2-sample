using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin.WebApi2;
using Owin.WebApi2.Services;

[assembly: OwinStartup(typeof(Startup))]

namespace Owin.WebApi2
{
    public partial class Startup
    {
        public void Configuration( IAppBuilder app )
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseErrorPage();
            
            var config = new HttpConfiguration();
            
            // Register Routes
            WebApiConfig.Register(config);

            // Register dependencies
            ConfigureDependencies(app, config);

            // Configure Authentication middleware
            ConfigureAuth(app, config);

            // configure Web API 
            app.UseWebApi(config);

            // configure swagger
            ConfigureSwagger(app, config);
        }
    }
}
