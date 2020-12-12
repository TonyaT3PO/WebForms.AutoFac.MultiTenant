namespace WebForms.AutoFac.MultiTenant.Data.Models.Tenants
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TenantUpdates12112020 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        ClientUrl = c.String(maxLength: 150),
                        Provider = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
