namespace Salaries.Shared;
public class SalaryViewModel : BaseViewModel
{
    public Guid EmployeeId { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal Bounus { get; set; }
}