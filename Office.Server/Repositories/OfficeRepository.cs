namespace Offices.Server;
public class OfficeRepository : BaseRepository<Office>, IOfficeRepository
{
    public OfficeRepository(DbContext dbContext) : base(dbContext)
    {
    }
}