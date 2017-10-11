using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Api_ELearning.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            SetupJsonFormatter(config);

            SetupAutoFac(config);
        }

        private static void SetupAutoFac(HttpConfiguration configuration)
        {
            if (configuration == null)
            {
                return;
            }

            AutofacConfig.Register(configuration);
        }

        private static void SetupJsonFormatter(HttpConfiguration configuration)
        {
            if (configuration == null)
            {
                return;
            }

            configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
