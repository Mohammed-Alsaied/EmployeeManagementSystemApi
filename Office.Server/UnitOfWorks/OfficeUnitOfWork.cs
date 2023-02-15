namespace Offices.Server;
public class OfficeUnitOfWork : BaseUnitOfWork<Office>, IOfficeUnitOfWork
{
    public OfficeUnitOfWork(IOfficeRepository repsitory) : base(repsitory)
    {
    }
}