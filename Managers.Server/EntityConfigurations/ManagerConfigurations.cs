using Persons.Shared;

namespace Managers.Server;
public class ManagerConfigurations : PersonConfiguration<Manager>
{
    public override void Configure(EntityTypeBuilder<Manager> builder)
    {
        //builder.Property(m => m.ManagerId).ValueGeneratedOnAdd();
    }
}