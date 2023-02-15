namespace Departments.Server;
public class Department : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal SalaryMin { get; set; }
    public decimal SalaryMax { get; set; }
    public Guid? HeadedBy { get; set; }
}