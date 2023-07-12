using DNA.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
public class IssueSeverityEntityConfiguration : IEntityTypeConfiguration<IssueSeverity>
{
    public void Configure(EntityTypeBuilder<IssueSeverity> builder)
    {
        builder.HasQueryFilter(i => i.IsDeleted == false);
        builder.ToTable("IssueSeverity");

        builder.Property(e => e.Severity)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}
