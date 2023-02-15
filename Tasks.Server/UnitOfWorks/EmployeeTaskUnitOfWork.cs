
public class EmployeeTaskUnitOfWork : BaseUnitOfWork<EmployeeTask>, IEmployeeTaskUnitOfWork
{
    public EmployeeTaskUnitOfWork(IEmployeeTaskRepository repsitory) : base(repsitory)
    {
    }
}