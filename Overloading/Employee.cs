using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    // Mapping each Table in the DataBase must be represented with a Class
    // Model: Class represent a table in the DB
    internal class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public Guid SecurityStamp { get; set; }
    }
}
