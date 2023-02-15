namespace Salaries.Server;
public class SalaryRepository : BaseRepository<Salary>, ISalaryRepository
{
    public SalaryRepository(DbContext dbContext) : base(dbContext)
    {
    }
}