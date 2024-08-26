using Microsoft.EntityFrameworkCore;
namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EF Core
            // EF Core
            // ORM Object Relational Mapper in .Net

            // Mapping
            // Code First: Generate table for each Class
            // DataBase First: Generate Class for each Table
            // LINQ => EF Core => SQL queries

            // Generating Schema
            // 1. TPC = Table Per Class = Default Behavior
            //          You have to deal with many tables
            //          No null values

            // 2. TPH = Table Per Hierarchy
            //          Many Classes with inheritance will go to same table
            //          You deal with a single table
            //          Creates null values

            // 3. TPCC = Table Per Concrete Class
            //           Concrete Class = Fully Implemented Class
            //           Avoid nulls
            //           Less number of tables

            // You choose between them according to the inheritance in your project
            #endregion

            #region EF Core vs ADO.Net vs Dapper
            // Search for the article on C# Corner
            // Before ORM everything was done manually

            // ADO.Net is part of the .Net framework
            // It was low level
            // It used SQL directly
            // Which means fine-grained control but also a lot of code to be written
            // ADO only worked on Windows Server and SQL Server

            // EF Core can work with Linux and MySQL
            // Is a high level ORM
            // Abstracts the database operations
            // Easier to work with
            // Supports LINQ
            // Supports SQL Server, MySQL, SQL Lite and PostgreSQL

            // Dapper
            // ORM from StackOverFlow team
            // Less features than EF Core but much faster
            // Provides fine control
            // Not suitable for all operations

            // ADO fine control
            // EF Core easier + features
            // Dapper faster
            #endregion

            #region Connecting to the database
            // You need to install Nuget packages
            // Microsoft.EntityFrameworkCore.SqlServer
            // Microsoft.EntityFrameworkCore.Tools

            // You need to create the DbContext
            // You need to do Migration
            // Add-Migration "Name"
            // watch the video to understand the migration syntax

            // To execute the migration
            /*
            CompanyDbContext context = new CompanyDbContext();
            context.Database.Migrate();
            */
            // or use Update-Database in terminal
            // If not working
            // Add Encrypt = false or
            // Add TrustServerCertificate = True
            // to the connection string

            // After each edit to the Classes you need to do a new migration
            // The normal practice is migrate once only after you finish everything

            // if you want to undo changes
            // Update-Database "Migration Name"
            // then use
            // Remove-Migration of last migration

            // so to update
            // migration => Update
            // to remove
            // update => migration

            // To remove the first migration
            // Update-Database 0
            // Remove-Migration

            #endregion

            #region CRUD Operations Add

            // C# Code is a managed code
            // Almost everything is under the control of CLR
            // Except few things like dealing with the database and opening external files
            // You need to use try .. finally code block to manage the connection

            /*            
            CompanyDbContext dbContext = new CompanyDbContext(); // To open connection with the database
            try
            {
                // CRUD
            }
            finally
            {
                // Release || Free || Deallocate || Close || Dispose unmanaged resources
                dbContext.Dispose();
            }
            */

            // Syntax Sugar
            // The connection will close automatically after finishing the code block
            /*
            using (CompanyDbContext dbContext = new CompanyDbContext())
            {
                // Your code is here
            }
            */

            // Currently no need for brackets
            using CompanyDbContext dbContext = new CompanyDbContext();
            Employee Emp01 = new Employee()
            {
                Name = "Karim",
                Age = 42,
                Salary = 4000,
                TotalSalary = 5000,
                Address = "Alexandria",
                Email = "Karim@yahoo.com",
                Phone = "00965 98890618"
            };

            Employee Emp02 = new Employee()
            {
                Name = "Aya",
                Age = 22,
                Salary = 2000,
                TotalSalary = 3000,
                Address = "Cairo",
                Email = "Aya@yahoo.com",
                Phone = "0100 1234567"
            };

            Console.WriteLine(dbContext.Entry(Emp01).State); // Detached
                                                             // To check the state of the object and its relation to the database
                                                             // State is an enum that has 4 conditions
                                                             // 1. Detached: the object has no relation with the database
                                                             // 2. Added: the object wasn't in the database but was just added
                                                             // 3. Unchanged: the object is in the database but not modified
                                                             // 4. Modified: the object is in database and has been just modified
                                                             // 5. Delete: the object in database but was just deleted

            // EF has something called tracker that follows the object changes

            // 4 ways to add an object to the database
            // Added locally

            /*
            dbContext.Employees.Add(Emp01);
            dbContext.Add(Emp01);
            dbContext.Set<Employee>().Add(Emp01);
            dbContext.Entry(Emp01).State = EntityState.Added;
            */

            // All of them are the same result the commonest is the first

            dbContext.Employees.Add(Emp01);
            dbContext.Employees.Add(Emp02);
            Console.WriteLine(dbContext.Entry(Emp01).State); // Added
            Console.WriteLine(dbContext.Entry(Emp02).State); // Added

            // Remember the add is locally only
            // To add to the database, you need to save
            dbContext.SaveChanges();
            Console.WriteLine(dbContext.Entry(Emp01).State); // Unchanged
            Console.WriteLine(dbContext.Entry(Emp02).State); // Unchanged
            Console.WriteLine("====================");
            Console.WriteLine($"Emp01 ID = {Emp01.Id}"); // Id will be generated by SQL
            Console.WriteLine($"Emp02 ID = {Emp02.Id}"); // Id will be generated by SQL

            // Each time you run the app he will add the object again and again in the database
            // you have to use truncate table in SQL to clear the table

            #endregion

            #region CRUD Operations Read = Retrieve = Insert
            // You will use LINQ
            // The sequence is the DbContext
            var Emp = (from E in dbContext.Employees
                       where E.Id == 1
                       select E).FirstOrDefault(); // to avoid exceptions
            Console.WriteLine(Emp?.Name ?? "Not Found");
            #endregion

            #region CRUD Operations Update
            var employee = (from E in dbContext.Employees
                       where E.Id == 1
                       select E).FirstOrDefault();
            Console.WriteLine(dbContext.Entry(employee).State); // Unchanged
            employee.Name = "Hamada";
            Console.WriteLine(dbContext.Entry(employee).State); // Modified
            dbContext.SaveChanges();
            Console.WriteLine(dbContext.Entry(employee).State); // Unchanged
            #endregion

            #region CRUD Operations Remove = Delete
            var employee01 = (from E in dbContext.Employees
                            where E.Id == 1
                            select E).FirstOrDefault();
            dbContext.Employees.Remove(employee01); // Removed locally
            Console.WriteLine(dbContext.Entry(employee01).State); // Deleted
            dbContext.SaveChanges(); // changes applied to database
            Console.WriteLine(dbContext.Entry(employee01).State); // Detached

            #endregion

            #region Relations in Mapping
            // Use Navigational Properties
            // For one to many relation, Check Classes Employee & Department
            // For many to many, Check Classes Student & Course
            // For simple many to many with no fields on the relation, you will do it directly and EF will create the third table
            // In many to many relation with fields on the relation, you will have to create a third Class = table
            #endregion





        }
    }
}
