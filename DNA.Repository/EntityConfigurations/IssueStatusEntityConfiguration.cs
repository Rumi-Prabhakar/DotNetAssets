using DNA.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

    public class IssueStatusEntityConfiguration : IEntityTypeConfiguration<IssueStatus>
    {
        public void Configure(EntityTypeBuilder<IssueStatus> builder)
        {
            builder.HasQueryFilter(i => i.IsDeleted == false);
            builder.ToTable("IssueStatus");

            builder.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }

