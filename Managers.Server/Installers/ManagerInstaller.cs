namespace Managers.Server;
public class ManagerInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<ManagerViewModel>, ManagerValidator>();
        services.AddScoped<IManagerRepository, ManagerRepository>();
        services.AddScoped<IManagerUnitOfWork, ManagerUnitOfWork>();
    }
}
