namespace WebForms.AutoFac.MultiTenant.Data.Models.Tenants
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationTenants : DbMigrationsConfiguration<WebForms.AutoFac.MultiTenant.Data.Models.Tenants.TenantDbContext>
    {
        public ConfigurationTenants()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebForms.AutoFac.MultiTenant.Data.Models.Tenants.TenantDbContext";
        }

        protected override void Seed(WebForms.AutoFac.MultiTenant.Data.Models.Tenants.TenantDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(
               a => a.Name,
               new Customer
               {
                   Name = "Tenant1",
                   ClientUrl = "https://localhost:44314/Tenant1",
                   Provider = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Tenant1App;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\Tenant1App.mdf"
               },
               new Customer
               {
                   Name = "Tenant2",
                   ClientUrl = "https://localhost:44314/Tenant2",
                   Provider = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Tenant2App;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\Tenant2App.mdf"
               }
            );

            context.SaveChanges();
        }
    }
}
