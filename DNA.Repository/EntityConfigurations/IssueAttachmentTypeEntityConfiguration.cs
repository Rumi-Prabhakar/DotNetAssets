using DNA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


    public class IssueAttachmentTypeEntityConfiguration : IEntityTypeConfiguration<IssueAttachmentType>
    {
        public void Configure(EntityTypeBuilder<IssueAttachmentType> builder)
        {
            builder.HasQueryFilter(i => i.IsDeleted == false);

            builder.ToTable("IssueAttachmentType");

            builder.Property(e => e.AttachmentType)
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
