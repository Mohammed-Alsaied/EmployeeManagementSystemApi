namespace EmployeeTasks.Server;
public class EmployeeTask : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid EmployeeId { get; set; }
    public Guid AssignedBy { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Statue? Statue { get; set; }
    public bool? IsEndedAtTime { get; set; }
}

