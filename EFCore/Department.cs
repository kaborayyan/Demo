using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        
        // Navigational Property => Many
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        // we can use any type of data collection

        // You need to create an actual object to store the data
        // Because the usual property will only create a reference
    }
}
