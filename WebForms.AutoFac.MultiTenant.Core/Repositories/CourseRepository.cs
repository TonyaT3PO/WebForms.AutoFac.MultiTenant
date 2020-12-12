using System.Collections.Generic;
using System.Linq;
using WebForms.AutoFac.MultiTenant.Data.Models.App;

namespace WebForms.AutoFac.MultiTenant.Core.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        internal AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Dtos.Course> List()
        {
            return _context.Courses
               .Select(c => new Dtos.Course()
               {
                   CourseNum = c.CourseNum,
                   Name = c.CourseName,
                   Description = c.CourseNarrative
               });
        }
    }
}