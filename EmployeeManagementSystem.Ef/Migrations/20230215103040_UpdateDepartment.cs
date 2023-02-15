using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.EF.Migrations
{
    public partial class UpdateDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryRange",
                table: "Department");

            migrationBuilder.AddColumn<decimal>(
                name: "SalaryRangeFrom",
                table: "Department",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SalaryRangeTo",
                table: "Department",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryRangeFrom",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "SalaryRangeTo",
                table: "Department");

            migrationBuilder.AddColumn<string>(
                name: "SalaryRange",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
