namespace EmployeeTasks.Server;
public class EmployeeTaskInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IValidator<EmployeeTaskViewModel>, EmployeeTaskValidator>();
        services.AddScoped<IEmployeeTaskRepository, EmployeeTaskRepository>();
        services.AddScoped<IEmployeeTaskUnitOfWork, EmployeeTaskUnitOfWork>();
    }
}
