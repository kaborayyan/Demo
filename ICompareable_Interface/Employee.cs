using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareable_Interface
{
    internal class Employee: IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }        
        public decimal Salary { get; set; }

        public int CompareTo(object? obj)
        {
            // +ve if this.Salary > Object.Salary
            // -ve if the opposite
            // 0 if equal

            Employee PassedEmployee = (Employee)obj; // Totally unsafe
            if (this.Salary > PassedEmployee.Salary)
            {
                return 1;
            }
            else if (this.Salary < PassedEmployee.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Salary = {Salary}";
        }
    }
}
