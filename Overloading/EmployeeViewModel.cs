using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    // A Class that represent the data that will be rendered in view
    internal class EmployeeViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        // Casting Operator Overloading
        public static explicit operator EmployeeViewModel(Employee employee)
        {
            string[]? Names = employee?.FullName?.Split(" ");
            return new EmployeeViewModel()
            {
                Email = employee?.Email,
                FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
                LastName = Names?.Length > 1 ? Names[1] : string.Empty
            };

        }
    }
}
