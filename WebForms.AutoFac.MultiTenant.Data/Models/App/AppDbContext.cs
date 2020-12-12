using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebForms.AutoFac.MultiTenant.Data.Models.App
{
    public class AppDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; } // Course
     
        public AppDbContext()
            : base("Name=AppConnectionString")
        {
        }

        public AppDbContext(string connectionString)
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