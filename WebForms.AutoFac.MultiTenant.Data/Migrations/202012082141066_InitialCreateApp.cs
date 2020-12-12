namespace WebForms.AutoFac.MultiTenant.Data.Models.App
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateApp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseNum = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CourseNarrative = c.String(),
                    })
                .PrimaryKey(t => t.CourseNum);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
