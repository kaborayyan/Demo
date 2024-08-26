using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class StudentCourse
    {
        [ForeignKey("Student")] // of Navigational Property
        public int StudentID { get; set; }
        
        [ForeignKey("Course")] // of Navigational Property
        public int CourseID { get; set; }
        public int Grade { get; set; }
        
        
        // Navigational Property
        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
