using System.Collections.Generic;
using WebForms.AutoFac.MultiTenant.Core.Dtos;

namespace WebForms.AutoFac.MultiTenant.Core.Repositories
{
    public interface ITenantRepository
    {
        IEnumerable<Tenant> List();
        Tenant GetTenant(string tenantName);
    }
}