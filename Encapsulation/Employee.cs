using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // Without Encapsulation => ID Attribute
    internal struct Employee
    {
        // How to do Encapsulation
        // 1. Private Attributes
        // 2. [Getter setter] - [Properties]
        // 3. Property ("Full", "Automatic", "Indexer")

        // Attributes
        public int ID;
        private string? name; // Private attributes in lower case
        private decimal salary; // Private attributes in lower case

        #region Getter Setter
        // Getter Setter
        public string? GetName()
        {
            return name;
        }

        // if i delete the setter, nobody can change the name after creating it
        public void SetName(string? _name)
        {
            name = _name?.Length > 5 ? _name.Substring(0, 5) : _name;
            // if longer than 5 characters take the first 5 only
            // Now we can control the data entered
        }
        #endregion

        #region Property
        // The easier way
        // The recommended way
        // Outside Class use the Property
        // Inside the class use the Attribute itself "its own scope"

        // propfull + TAB Twice for a full property
        // prop + TAB for an auto property

        // This is a full Property "Not common"
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set // if changed to "private set" no one will be able to modify it
            {
                salary = value < 3000? 3000:value;
                // value is a reserved keyword
            }
        }

        public int Age { get; set; } // This is a Property not an Attribute
        // The compiler will generate a Hidden Private Attribute automatically "Backing Field"

        public decimal Deduction // A Property not an Attribute
        {
            get { return salary * 0.2M; }
        }
        #endregion

        // Constructors (Rt click + quick actions)
        public Employee(int id, string? userName, decimal salary, int age)
        {
            ID = id;
            name = userName;
            this.salary = salary;
            this.Age = age;
        }

        // Methods
        public override string ToString()
        {
            return $"ID = {ID}\nName = {name}\nSalary = {salary:c}\nAge = {Age}";
        }

    }
}
