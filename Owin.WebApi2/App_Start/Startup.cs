﻿using System.Web.Http;
using Swashbuckle.Application;

namespace Owin.WebApi2
{
    public partial class Startup
    {
        private void ConfigureSwagger( IAppBuilder app, HttpConfiguration config )
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Web API Swagger Doc")
                 .Description("Web API documentation generated by swashbuckle/swagger");
            })
            .EnableSwaggerUi();
        }
    }
}
