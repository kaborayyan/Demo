using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }

        // public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        // Relation many to many with Student
        // You have to create an instance
        // In simple many to many relation = no fields on the relation

        // Navigational Property
        // For many to many with fields on the relation
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
    }
}
