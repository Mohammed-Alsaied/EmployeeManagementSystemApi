namespace Offices.Server;
public class OfficeConfigurations : BaseEntityConfiguration<Office>
{
    public override void Configure(EntityTypeBuilder<Office> builder)
    {
        base.Configure(builder);
        builder.Property(o => o.City).IsRequired();
        builder.Property(o => o.PhoneNumber).IsRequired();
        builder.Property(o => o.Address1).IsRequired();
        builder.Property(o => o.State).IsRequired();
        builder.Property(o => o.City).IsRequired();
        builder.Property(o => o.Country).IsRequired();

    }
}