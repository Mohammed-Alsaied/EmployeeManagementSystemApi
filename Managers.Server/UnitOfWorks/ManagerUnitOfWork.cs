namespace Managers.Server;
public class ManagerUnitOfWork : BaseUnitOfWork<Manager>, IManagerUnitOfWork
{
    public ManagerUnitOfWork(IManagerRepository repsitory) : base(repsitory)
    {
    }
}