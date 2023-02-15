namespace Offices.Server;
public class OfficeInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IValidator<OfficeViewModel>, OfficeValidator>();
        services.AddScoped<IOfficeRepository, OfficeRepository>();
        services.AddScoped<IOfficeUnitOfWork, OfficeUnitOfWork>();
    }
}
