using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Owin.WebApi2.Services;

namespace Owin.WebApi2
{
    public partial class Startup
    {
        private void ConfigureDependencies( IAppBuilder app, HttpConfiguration config )
        {
            var builder = new ContainerBuilder();
            
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<HelloWorldService>()
                   .As<IHelloWorldService>()
                   .InstancePerRequest();

            // Run other optional steps, like registering filters,
            // per-controller-type services, etc., then set the dependency resolver
            // to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
        }
    }
}
