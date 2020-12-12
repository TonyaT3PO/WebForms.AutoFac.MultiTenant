using System.Data.Entity;

namespace WebForms.AutoFac.MultiTenant.Data.Models.Tenants
{
    public class TenantDbContext : DbContext, ITenantDbContext
    {
        public DbSet<Customer> Customers { get; set; } // Customers

        
        public TenantDbContext()
            : base("Name=TenantConnectionString")
        {
        }

        public TenantDbContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}