using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.EF.Migrations
{
    public partial class UpdateSalaryRelationWithEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_SalaryId",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SalaryId",
                table: "Employee",
                column: "SalaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_SalaryId",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SalaryId",
                table: "Employee",
                column: "SalaryId",
                unique: true,
                filter: "[SalaryId] IS NOT NULL");
        }
    }
}
