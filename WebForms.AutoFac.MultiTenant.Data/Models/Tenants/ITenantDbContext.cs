using System.Data.Entity;
using System.Data.SqlClient;

namespace WebForms.AutoFac.MultiTenant.Data.Models.Tenants
{
    public interface ITenantDbContext
    {
        DbSet<Customer> Customers { get; set; }

        bool IsSqlParameterNull(SqlParameter param);
    }
}