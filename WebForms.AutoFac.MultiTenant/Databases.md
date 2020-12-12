# Markdown File

https://stackoverflow.com/questions/13469881/how-do-i-enable-ef-migrations-for-multiple-contexts-to-separate-databases

Enable-Migrations -ContextTypeName WebForms.AutoFac.MultiTenant.Data.Models.Tenants.TenantDbContext
Enable-Migrations -ContextTypeName WebForms.AutoFac.MultiTenant.Data.Models.App.AppDbContext

add-migration InitialAppSchema -IgnoreChanges -ConfigurationTypeName ConfigurationApp -ConnectionStringName AppConnectionString
Update-Database -ConfigurationTypeName ConfigurationApp -ConnectionStringName AppConnectionString

add-migration InitialTenantSchema -IgnoreChanges -ConfigurationTypeName ConfigurationTenants -ConnectionStringName TenantConnectionString

Update-Database -ConfigurationTypeName ConfigurationTenants -ConnectionStringName TenantConnectionString

add-migration TenantSeedData -IgnoreChanges -ConfigurationTypeName ConfigurationTenants -ConnectionStringName TenantConnectionString

add-migration TenantUpdates-12-11-2020 -ConfigurationTypeName ConfigurationTenants -ConnectionStringName TenantConnectionString
