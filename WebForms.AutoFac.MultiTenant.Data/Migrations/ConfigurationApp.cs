namespace WebForms.AutoFac.MultiTenant.Data.Models.App
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationApp : DbMigrationsConfiguration<WebForms.AutoFac.MultiTenant.Data.Models.App.AppDbContext>
    {
        public ConfigurationApp()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebForms.AutoFac.MultiTenant.Data.Models.App.AppDbContext";
        }

        protected override void Seed(WebForms.AutoFac.MultiTenant.Data.Models.App.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Courses.AddOrUpdate(
               a => a.CourseName,
               new Course
               {
                   CourseName = "Course 1 Tenant 1",
                   CourseNarrative = "Description of Course 1 for Tenant 1"
               },
               new Course
               {
                   CourseName = "Course 2 Tenant 1",
                   CourseNarrative = "Description of Course 2 for Tenant 1"
               }
            );
            context.SaveChanges();
        }
    }
}
