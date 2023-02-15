namespace Salaries.Server;
public class SalaryUnitOfWork : BaseUnitOfWork<Salary>, ISalaryUnitOfWork
{
    public SalaryUnitOfWork(ISalaryRepository repsitory) : base(repsitory)
    {
    }
}