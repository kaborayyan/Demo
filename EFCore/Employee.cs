using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    #region Mapping
    // EF Core supports 4 ways of mapping Classes to the database
    // A Class may be transformed to "Table - View - Function"

    // 1. By Convention "Default"
    // The EF core will turn the next class to a table.
    // Id will be a primary key with Identity Constrain.
    // It will make this with any public int that have the name of Id.
    // or ID or any part of the name like EmployeeId.
    // Not practical to use.

    // 2. Data Annotations
    // A set of attributes
    // Can be used for data validation

    // 3. Fluent API
    // To use it you have to override OnModelCreating

    // 4. Class Configuration
    // Create separate class for this
    // Class for each Class
    // You use Fluent API inside this Class
    // But you have to call it in OnModelCreating

    #endregion

    #region Class with data annotation
    [Table("Employee", Schema = "dbo")]
    internal class Employee
    {
        // POCO Class
        // Plain Old CLR Object Class
        // No special functionality or behavior
        // For storing data only

        [Key] // Not null PK to the next Property
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // autoincrement
        public int Id { get; set; } // PK Identity (1, 1) not null

        [Required]
        // [Column(TypeName ="varchar(50)")] // TAKE CARE OF THE SYNTAX
        // Same as the next
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Please enter full name.")] // data validation nothing equal in database
        public string Name { get; set; } // nvarchar(max)

        [Column(TypeName = "money")]
        public double Salary { get; set; } // float

        [Required]
        [Range(20, 60)] // data validation nothing equal in database
        public int? Age { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Please enter full Address.")]
        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [NotMapped] // Derived attribute
        public int TotalSalary { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }

        // Navigational Property => One
        public Department Department { get; set; }
    }
    #endregion
    
}
