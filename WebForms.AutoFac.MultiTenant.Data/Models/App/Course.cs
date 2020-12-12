using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebForms.AutoFac.MultiTenant.Data.Models.App
{
    public class Course
    {
        [Key]
        public int CourseNum { get; set; }
        public string CourseName { get; set; }
        public string CourseNarrative { get; set; }
        
    }

    

}