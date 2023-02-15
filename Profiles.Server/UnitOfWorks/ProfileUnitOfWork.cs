
using Profiles.Server;

public class ProfileUnitOfWork : BaseUnitOfWork<Profiles.Server.Profile>, IProfileUnitOfWork
{
    public ProfileUnitOfWork(IProfileRepository repsitory) : base(repsitory)
    {
    }
}