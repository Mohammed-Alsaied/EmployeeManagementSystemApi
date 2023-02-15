namespace Employees.Server;
public class EmployeeUnitOfWork : BaseUnitOfWork<Employee>, IEmployeeUnitOfWork
{
    public EmployeeUnitOfWork(IEmployeeRepository repsitory) : base(repsitory)
    {
    }
}