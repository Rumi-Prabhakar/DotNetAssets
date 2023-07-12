using DNA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


    public class IssueClassificationEntityConfiguration : IEntityTypeConfiguration<IssueClassification>
    {
        public void Configure(EntityTypeBuilder<IssueClassification> builder)
        {
            builder.HasQueryFilter(i => i.IsDeleted == false);

            builder.ToTable("IssueClassification");

            builder.Property(e => e.Classification)
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
