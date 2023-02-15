namespace Departments.Server;
public class DepartmentInstaller : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IValidator<DepartmentViewModel>, DepartmentValidator>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IDepartmentUnitOfWork, DepartmentUnitOfWork>();
    }
}
