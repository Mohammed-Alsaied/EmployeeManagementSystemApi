namespace Departments.Server;
public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(DbContext dbContext) : base(dbContext)
    {
    }
}