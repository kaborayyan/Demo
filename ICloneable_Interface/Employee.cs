using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable_Interface
{
    internal class Employee : ICloneable // To use Clone()
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public StringBuilder LastName { get; set; }
        public decimal Salary { get; set; }

        // Copy Constructor

        public Employee(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Salary = employee.Salary;
        }
        public Employee()
        {

        }
        
        // For Deep Copy
        public object Clone()
        {
            return new Employee(this);
            //{ 
            //    Id = this.Id, // Id of the new Object but this.Id refer to the caller old Object
            //    FirstName = this.FirstName,
            //    LastName = this.LastName,
            //    Salary = this.Salary
            //};
        }

        public override string ToString()
        {
            return $"ID = {Id}, First Name = {FirstName}, Last Name = {LastName}, Salary = {Salary}";
        }
    }
}
