namespace Salaries.Server;
public class SalaryConfigurations : BaseEntityConfiguration<Salary>
{
    public override void Configure(EntityTypeBuilder<Salary> builder)
    {
        base.Configure(builder);
        builder.Property(d => d.Id).ValueGeneratedOnAdd();
        builder.Property(d => d.CreationDate).HasDefaultValueSql("GETDATE()");
        builder.Property(s => s.BasicSalary).IsRequired();
        builder.Property(s => s.Bounus).IsRequired();
    }
}