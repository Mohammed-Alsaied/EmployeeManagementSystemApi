using Employees.Server;

namespace Profiles.Server;
public class ProfileConfigurations : BaseEntityConfiguration<Profile>
{
    public override void Configure(EntityTypeBuilder<Profile> builder)
    {
        base.Configure(builder);
        builder.Property(e => e.EmployeeId).IsRequired();
        builder.Property(e => e.Team).IsRequired();
        builder.Property(e => e.ManagerName).IsRequired();
        builder.Property(e => e.Knowledge).IsRequired();
        builder.Property(e => e.Expertise).IsRequired();
        builder.Property(e => e.CurrentWorkProjects).IsRequired();

        builder.HasOne<Employee>()
            .WithOne()
            .HasForeignKey<Profile>(e => e.EmployeeId)
            .HasPrincipalKey<Employee>(e => e.Id);
    }
}