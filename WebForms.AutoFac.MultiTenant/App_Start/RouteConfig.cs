using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using WebForms.AutoFac.MultiTenant.Core.Repositories;

namespace WebForms.AutoFac.MultiTenant
{
    public static class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {

            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);


            //TenantRepository tenants = new TenantRepository();
            //var tenantRoutes = tenants.GetTenantNamesForRoute();

            var tenantRoutes = "Tenant1|Tenant2";


            routes.MapPageRoute("default_all", "{tenant}/default", "~/Default.aspx",
                    false, null,
                    new RouteValueDictionary { { "tenant", tenantRoutes } });
        }
    }
}
