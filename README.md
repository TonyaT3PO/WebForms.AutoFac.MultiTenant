# WebForms.AutoFac.MultiTenant
500.19 Error using Autofac Multitenant with ASP.Net WebForms

Uncomment the tenant app connection strings and run 

Update-Database -ConfigurationTypeName ConfigurationTenants -ConnectionStringName TenantConnectionString
Update-Database -ConfigurationTypeName ConfigurationApp -ConnectionStringName AppConnectionString
Update-Database -ConfigurationTypeName ConfigurationApp -ConnectionStringName AppConnectionString2
