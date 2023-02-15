using Common.ViewModels;

namespace EmployeeTasks.Shared;
public class EmployeeTaskViewModel : BaseViewModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid EmployeeId { get; set; }
    public Guid AssignedBy { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}