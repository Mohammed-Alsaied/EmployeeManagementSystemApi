using System.ComponentModel.DataAnnotations;

namespace Employees.Server;
public class Employee : Person
{
    [EmailAddress]
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }
    public Guid? OfficeCode { get; set; }
    public Guid? DepartmentId { get; set; }
    public Guid? SalaryId { get; set; }

}