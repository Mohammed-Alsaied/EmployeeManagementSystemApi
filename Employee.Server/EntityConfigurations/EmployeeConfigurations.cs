using Departments.Server;
using Offices.Server;
using Salaries.Server;

namespace Employees.Server;
public class EmployeeConfigurations : PersonConfiguration<Employee>
{
    public override void Configure(EntityTypeBuilder<Employee> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.OfficeCode).IsRequired();
        builder.Property(e => e.Email).IsRequired();
        builder.Property(e => e.PhoneNumber).IsRequired();
        builder.HasIndex(e => e.PhoneNumber).IsUnique();
        builder.Property(e => e.JobTitle).IsRequired();

        builder.HasOne<Department>()
               .WithMany()
               .HasForeignKey(e => e.DepartmentId)
               .HasPrincipalKey(d => d.Id);

        builder.HasOne<Office>()
            .WithMany()
            .HasForeignKey(e => e.OfficeCode)
            .HasPrincipalKey(e => e.Id);

        builder.HasOne<Salary>()
            .WithMany()
            .HasForeignKey(e => e.SalaryId)
            .HasPrincipalKey(e => e.Id);
    }
}