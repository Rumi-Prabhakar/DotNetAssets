using DNA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class IssueDetailEntityConfiguration : IEntityTypeConfiguration<IssueDetail>
    {
        public void Configure(EntityTypeBuilder<IssueDetail> builder)
        {
            builder.HasQueryFilter(i => i.IsDeleted == false);

            builder.ToTable("IssueDetail");

            builder.HasOne(d => d.Issue)
                .WithMany(p => p.IssueDetails)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IssueDeta__Issue__2C3393D0");
        }
    }
