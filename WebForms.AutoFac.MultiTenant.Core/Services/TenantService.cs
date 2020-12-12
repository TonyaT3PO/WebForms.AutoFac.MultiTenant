using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForms.AutoFac.MultiTenant.Core.Dtos;
using WebForms.AutoFac.MultiTenant.Core.Repositories;

namespace WebForms.AutoFac.MultiTenant.Core.Services
{
    public class TenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantService(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public IEnumerable<Tenant> List()
        {
            return _tenantRepository.List();
        }
        public Tenant FindTenant(string tenantName)
        {
            return _tenantRepository.GetTenant(tenantName);
        }

        

    }
}