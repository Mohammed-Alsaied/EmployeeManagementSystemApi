using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.EF.Migrations
{
    public partial class UpdateSalaryAddBasicSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Salary",
                newName: "BasicSalary");

            migrationBuilder.RenameColumn(
                name: "SalaryRangeTo",
                table: "Department",
                newName: "SalaryMin");

            migrationBuilder.RenameColumn(
                name: "SalaryRangeFrom",
                table: "Department",
                newName: "SalaryMax");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BasicSalary",
                table: "Salary",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "SalaryMin",
                table: "Department",
                newName: "SalaryRangeTo");

            migrationBuilder.RenameColumn(
                name: "SalaryMax",
                table: "Department",
                newName: "SalaryRangeFrom");
        }
    }
}
