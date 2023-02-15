using Common.ViewModels;

namespace EmployeeTasks.Shared;
public class ProfileViewModel : BaseViewModel
{
    public Guid EmployeeId { get; set; }
    public string Team { get; set; }
    public string ManagerName { get; set; }
    public string? DirectReports { get; set; }
    public string? CareerAccomplishments { get; set; }
    public string Knowledge { get; set; }
    public string Expertise { get; set; }
    public string CurrentWorkProjects { get; set; }
    public string? ActivitySreams { get; set; }
    public string? PersonalStatment { get; set; }
}