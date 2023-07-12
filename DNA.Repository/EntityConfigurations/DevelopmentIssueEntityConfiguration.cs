using DNA.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class DevelopmentIssueEntityConfiguration : IEntityTypeConfiguration<DevelopmentIssue>
    {
        public void Configure(EntityTypeBuilder<DevelopmentIssue> builder)
        {
            builder.HasQueryFilter(e => e.IsDeleted == false);
            builder.Property(e => e.IssueTitle).HasMaxLength(200);
            builder.Property(e => e.ResolutionDuration).HasColumnType("decimal(18, 0)");

            builder.HasOne(d => d.IssueClassification)
                    .WithMany(p => p.DevelopmentIssues)
                    .HasForeignKey(d => d.IssueClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Developme__Issue__34C8D9D1");

            builder.HasOne(d => d.IssueSeverity)
                .WithMany(p => p.DevelopmentIssues)
                .HasForeignKey(d => d.Severity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Developme__Sever__29572725");

            builder.HasOne(d => d.Status)
                .WithMany(p => p.DevelopmentIssues)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Developme__Statu__286302EC");
        }
}
