namespace Employees.Server;
public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(DbContext dbContext) : base(dbContext)
    {
    }
}