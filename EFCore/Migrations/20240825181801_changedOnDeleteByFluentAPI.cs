using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class changedOnDeleteByFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departments_DepartmentID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departments_DepartmentID",
                schema: "dbo",
                table: "Employee",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departments_DepartmentID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departments_DepartmentID",
                schema: "dbo",
                table: "Employee",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");
        }
    }
}
