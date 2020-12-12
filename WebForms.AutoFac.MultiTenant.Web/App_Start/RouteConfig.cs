using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebForms.AutoFac.MultiTenant.Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           
            //var tenantRoutes = "Tenant1|Tenant2";

            //routes.MapPageRoute("DefaultRoute", "{tenant}/default", "~/Default.aspx",
            //        false, null,
            //        new RouteValueDictionary { { "tenant", tenantRoutes } });

            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);


        }
    }
}
