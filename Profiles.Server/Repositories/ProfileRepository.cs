namespace Profiles.Server;
public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
{
    public ProfileRepository(DbContext dbContext) : base(dbContext)
    {
    }
}