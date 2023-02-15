namespace Salaries.Server;
public class SalaryInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IValidator<SalaryViewModel>, SalaryValidator>();
        services.AddScoped<ISalaryRepository, SalaryRepository>();
        services.AddScoped<ISalaryUnitOfWork, SalaryUnitOfWork>();
    }
}
