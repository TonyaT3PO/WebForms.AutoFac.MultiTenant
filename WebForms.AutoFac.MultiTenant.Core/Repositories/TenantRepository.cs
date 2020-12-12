using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebForms.AutoFac.MultiTenant.Core.Dtos;
using WebForms.AutoFac.MultiTenant.Data.Models.Tenants;

namespace WebForms.AutoFac.MultiTenant.Core.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly TenantDbContext _context;

        public TenantRepository(TenantDbContext context)
        {
            _context = context;
            
        }

        public IEnumerable<Tenant> List()
        {
             return _context.Customers
                .Select(c => new Tenant()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ClientUrl = c.ClientUrl,
                    Provider = c.Provider
                    
                });
            
        }

        public Tenant GetTenant(string tenantName)
        {
            
            return _context.Customers
                .Where(c => c.Name == tenantName)
                .Select(c => new Tenant()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ClientUrl = c.ClientUrl,
                    Provider = c.Provider
                }).FirstOrDefault();
                    
            
        }

        public string GetTenantNamesForRoute()
        {
            var customers = _context.Customers
                .Select(c => new 
                {
                    Name = c.Name,

                }).ToArray();

            var tenants = string.Empty;

            foreach (var customer in customers)
            {
                string name = customer.Name.ToString();
                tenants += name.ToString() + "|";
            }
            tenants = tenants.Remove(tenants.LastIndexOf("|"));
            return tenants;

        }
    }
}
