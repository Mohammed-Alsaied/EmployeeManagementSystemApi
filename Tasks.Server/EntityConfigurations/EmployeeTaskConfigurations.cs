using Employees.Server;
using Managers.Server;

namespace EmployeeTasks.Server;
public class EmployeeTaskConfigurations : BaseEntityConfiguration<EmployeeTask>
{
    public override void Configure(EntityTypeBuilder<EmployeeTask> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.Description).IsRequired();
        builder.Property(e => e.EmployeeId).IsRequired();
        builder.Property(e => e.StartDate).IsRequired();
        builder.Property(e => e.EndDate).IsRequired();

        builder.HasOne<Employee>()
            .WithMany()
            .HasForeignKey(e => e.EmployeeId)
            .HasPrincipalKey(e => e.Id);

        builder.HasOne<Manager>()
            .WithMany()
            .HasForeignKey(e => e.AssignedBy)
            .HasPrincipalKey(e => e.Id);
    }
}