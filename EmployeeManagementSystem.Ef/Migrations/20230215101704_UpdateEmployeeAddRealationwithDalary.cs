using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.EF.Migrations
{
    public partial class UpdateEmployeeAddRealationwithDalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId1",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Salary_Employee_EmployeeId",
                table: "Salary");

            migrationBuilder.DropIndex(
                name: "IX_Salary_EmployeeId",
                table: "Salary");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentId1",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DepartmentId1",
                table: "Employee",
                newName: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SalaryId",
                table: "Employee",
                column: "SalaryId",
                unique: true,
                filter: "[SalaryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Salary_SalaryId",
                table: "Employee",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Salary_SalaryId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_SalaryId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "SalaryId",
                table: "Employee",
                newName: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_EmployeeId",
                table: "Salary",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId1",
                table: "Employee",
                column: "DepartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId1",
                table: "Employee",
                column: "DepartmentId1",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_Employee_EmployeeId",
                table: "Salary",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
