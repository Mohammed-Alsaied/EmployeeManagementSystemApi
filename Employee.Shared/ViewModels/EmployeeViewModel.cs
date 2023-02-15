using System.ComponentModel.DataAnnotations;

namespace Employees.Shared;
public class EmployeeViewModel : PersonViewModel
{
    [EmailAddress]
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }
    public Guid? OfficeCode { get; set; }
    public Guid? DepartmentId { get; set; }
    public Guid? SalaryId { get; set; }
    //public Department? Department { get; set; }
    //public Salary? Salary { get; set; }
}