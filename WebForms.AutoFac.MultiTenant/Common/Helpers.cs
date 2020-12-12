using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.AutoFac.MultiTenant.Common
{
    public class Helpers
    {
        public static string TenantName()
        {
            string tenantName = "";

            string[] urlParts = null;
            HttpContext httpContext = HttpContext.Current;
            urlParts = httpContext.Request.Url.Segments.Select(x => x.TrimEnd('/')).Skip(1).ToArray();
            tenantName = urlParts[0];

            return tenantName;
        }
    }
}