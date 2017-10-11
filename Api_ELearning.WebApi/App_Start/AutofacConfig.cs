using System;
using System.Web.Http;
using Api_ELearning.DataAccess.DataContext;
using Api_ELearning.DataAccess.Repositories;
using Autofac;
using Autofac.Integration.WebApi;

namespace Api_ELearning.WebApi
{
    public class AutofacConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), "The HTTP configuration cannot be NULL");
            }

            var builder = new ContainerBuilder();

            RegisterApiInfrastructureWithBuilder(builder);
            RegisterDependencies(builder);
            SetAutofacDependencyResolver(configuration, builder);
        }

        private static void RegisterDependencies(ContainerBuilder builder)
        {
            if (builder == null)
            {
                return;
            }

            builder.RegisterType<LearningContext>().AsSelf().InstancePerRequest();
            builder.RegisterType<LearningRepository>().As<ILearningRepository>().InstancePerRequest();
        }

        private static void RegisterApiInfrastructureWithBuilder(ContainerBuilder builder)
        {
            if (builder == null)
            {
                return;
            }

            builder.RegisterApiControllers(typeof (WebApiApplication).Assembly);
        }

        private static void SetAutofacDependencyResolver(HttpConfiguration configuration, ContainerBuilder builder)
        {
            if (configuration == null || builder == null)
            {
                return;
            }

            var container = builder.Build();
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}