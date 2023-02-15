
namespace EmployeeTasks.Server;
public class EmployeeTaskRepository : BaseRepository<EmployeeTask>, IEmployeeTaskRepository
{
    public EmployeeTaskRepository(DbContext dbContext) : base(dbContext)
    {
    }
}