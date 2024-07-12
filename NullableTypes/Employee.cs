using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }
    }

    class Department
    {
        public string DeptName { get; set; }
    }
}
