using Autofac.Multitenant;
using System.Web;
using WebForms.AutoFac.MultiTenant.Common;

namespace WebForms.AutoFac.MultiTenant
{
    public class TenantIdentificationStrategy : ITenantIdentificationStrategy
    {


        public bool TryIdentifyTenant(out object tenantId)
        {
            var context = HttpContext.Current;
            try
            {
                if (context == null || context.Request == null)
                {
                    tenantId = null;
                    return false;
                }
            }
            catch (HttpException)
            {
                // Happens at app startup in IIS 7.0
            }


            tenantId = Helpers.TenantName();
            return tenantId != null;
        }

    }

}
