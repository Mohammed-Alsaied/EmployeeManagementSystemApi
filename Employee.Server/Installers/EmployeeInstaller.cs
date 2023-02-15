namespace Employees.Server;
public class EmployeeInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<EmployeeViewModel>, EmployeeValidator>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IEmployeeUnitOfWork, EmployeeUnitOfWork>();
    }
}
