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



        }
    }
}
