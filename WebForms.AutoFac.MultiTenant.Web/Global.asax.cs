using Autofac;
using Autofac.Integration.Web;
using Autofac.Multitenant;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using WebForms.AutoFac.MultiTenant.Core.Repositories;
using WebForms.AutoFac.MultiTenant.Core.Services;
using WebForms.AutoFac.MultiTenant.Data.Models.App;
using WebForms.AutoFac.MultiTenant.Data.Models.Tenants;

namespace WebForms.AutoFac.MultiTenant.Web
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        private static IContainerProvider _containerProvider;

        public IContainerProvider ContainerProvider => _containerProvider;
        

        void Application_Start(object sender, EventArgs e)
        {
            
            MultiTenantContainerConfig();
            //ContainerConfig();
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        

        public void ContainerConfig()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<MyContext>().InstancePerLifetimeScope();
            builder.RegisterType<TenantDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<TenantRepository>().As<ITenantRepository>().SingleInstance();
            

            // Once you're done registering things, set the container
            // provider up with your registrations.
            _containerProvider = new ContainerProvider(builder.Build());
        }

        public void MultiTenantContainerConfig()
        {
            var context = new TenantDbContext();
            var tenantRepository = new TenantRepository(context);
            var tenantService = new TenantService(tenantRepository);
            var tenants = tenantService.List();

            var builder = new ContainerBuilder();
            var tenantIdStrategy = new TenantIdentificationStrategy();

            builder.RegisterType<TenantDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<TenantRepository>().As<ITenantRepository>().SingleInstance();

            builder.RegisterInstance(tenantIdStrategy).As<ITenantIdentificationStrategy>();
            var multitenantContainer = new MultitenantContainer(tenantIdStrategy, builder.Build());

            foreach (var tenant in tenants)
            {
                var connectionString = tenant.Provider;

                multitenantContainer.ConfigureTenant(tenant.Name, b =>
                {
                    b.Register(appContext => new AppDbContext(connectionString))
                        .InstancePerTenant()
                        .AsSelf();

                    b.RegisterType<CourseRepository>()
                        .As<ICourseRepository>();
                });
            }

            _containerProvider = new ContainerProvider(multitenantContainer);
        }
    }
}