
namespace Managers.Server;
public class ManagerRepository : BaseRepository<Manager>, IManagerRepository
{
    public ManagerRepository(DbContext dbContext) : base(dbContext)
    {
    }
}