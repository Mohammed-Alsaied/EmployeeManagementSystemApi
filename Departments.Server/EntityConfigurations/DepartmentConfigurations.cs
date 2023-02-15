namespace Departments.Server;
public class DepartmentConfigurations : BaseEntityConfiguration<Department>
{
    public override void Configure(EntityTypeBuilder<Department> builder)
    {
        base.Configure(builder);
        builder.Property(d => d.Id).ValueGeneratedOnAdd();
        builder.Property(d => d.CreationDate).HasDefaultValueSql("GETDATE()");
        //builder.HasOne<Manager>()
        //    .WithOne()
        //    .HasForeignKey<Department>(m => m.HeadedBy);
    }
}