using Profiles.Shared;

namespace Profiles.Server;
public class ProfileInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<ProfileViewModel>, ProfileValidator>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IProfileUnitOfWork, ProfileUnitOfWork>();
    }
}
