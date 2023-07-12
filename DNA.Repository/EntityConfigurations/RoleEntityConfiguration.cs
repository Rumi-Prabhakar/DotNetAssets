using DNA.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Repository.EntityConfigurations
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasQueryFilter(i => i.IsDeleted == false);

            builder.ToTable("Roles");

            builder.Property(r => r.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
