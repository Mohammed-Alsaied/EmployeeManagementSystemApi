using Offices.Server;
using Profiles.Server;
using Salaries.Server;

namespace EmployeeManagementSystem.EF
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Employee).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Manager).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Department).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeTask).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Profile).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Office).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Salary).Assembly);
        }

    }
}