using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        // public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        // Many to many relation with Course
        // You have to create an instance
        // In simple many to many relation = no fields on the relation

        // Navigational Property for many to many with fields
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
