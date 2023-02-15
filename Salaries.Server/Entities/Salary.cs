namespace Salaries.Server;
public class Salary : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal Bounus { get; set; }
    public decimal TotalSalary => BasicSalary + (Bounus * BasicSalary);
    public decimal Annual => TotalSalary * 12;
}