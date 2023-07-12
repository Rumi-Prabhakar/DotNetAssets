using DNA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IssueResolutionEntityConfiguration :IEntityTypeConfiguration<IssueResolution>
{
    public void Configure(EntityTypeBuilder<IssueResolution> builder)
    {
        builder.HasQueryFilter(i => i.IsDeleted == false);
    }
}
