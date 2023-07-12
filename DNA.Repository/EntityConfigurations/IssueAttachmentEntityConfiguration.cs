using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DNA.Entities;

    public class IssueAttachmentEntityConfiguration : IEntityTypeConfiguration<IssueAttachment>
    {
        public void Configure(EntityTypeBuilder<IssueAttachment> builder)
        {
            builder.HasQueryFilter(i => i.IsDeleted == false);
            builder.ToTable("IssueAttachment");

            builder.Property(e => e.AttachmentId)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.AttachmentType)
                .WithMany(p => p.IssueAttachments)
                .HasForeignKey(d => d.AttachmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueAtta__Attac__31EC6D26");

            builder.HasOne(d => d.Issue)
                .WithMany(p => p.IssueAttachments)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueAtta__Issue__30F848ED");
        }
    }