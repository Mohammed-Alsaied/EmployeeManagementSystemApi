namespace Departments.Server;
public class DepartmentUnitOfWork : BaseUnitOfWork<Department>, IDepartmentUnitOfWork
{
    public DepartmentUnitOfWork(IDepartmentRepository repsitory) : base(repsitory)
    {
    }
}