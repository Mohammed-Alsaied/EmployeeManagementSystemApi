using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.EF.Migrations
{
    public partial class UpdateOfficeRelationWithEMployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_OfficeCode",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OfficeCode",
                table: "Employee",
                column: "OfficeCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_OfficeCode",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OfficeCode",
                table: "Employee",
                column: "OfficeCode",
                unique: true);
        }
    }
}
