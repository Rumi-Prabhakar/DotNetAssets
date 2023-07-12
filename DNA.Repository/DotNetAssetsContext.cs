using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using DNA.Entities;
using DNA.Logger;
using DNA.Repository.EntityConfigurations;

public partial class DotNetAssetsContext : DbContext
    {
        private INLogManager NLog;
        public DotNetAssetsContext()
        {
        }

        public DotNetAssetsContext(DbContextOptions<DotNetAssetsContext> options)
            : base(options)
        {
           
        }

        public virtual DbSet<DevelopmentIssue> DevelopmentIssues { get; set; } = null!;
        public virtual DbSet<IssueAttachment> IssueAttachments { get; set; } = null!;
        public virtual DbSet<IssueAttachmentType> IssueAttachmentTypes { get; set; } = null!;
        public virtual DbSet<IssueClassification> IssueClassifications { get; set; } = null!;
        public virtual DbSet<IssueDetail> IssueDetails { get; set; } = null!;
        public virtual DbSet<IssueSeverity> IssueSeverities { get; set; } = null!;
        public virtual DbSet<IssueStatus> IssueStatuses { get; set; } = null!;

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //if (!optionsBuilder.IsConfigured)
            //{
            //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                                
            //    optionsBuilder
            //        .LogTo(NLog.LogInfo, Microsoft.Extensions.Logging.LogLevel.Information);
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                                                                               
            modelBuilder.ApplyConfiguration(new DevelopmentIssueEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueAttachmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueAttachmentTypeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueClassificationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueResolutionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueSeverityEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IssueStatusEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RoleEntityConfiguration());

            //modelBuilder.Entity<DevelopmentIssue>(entity =>
            //{
            //    entity.Property(e => e.IssueTitle).HasMaxLength(200);

            //    entity.Property(e => e.ResolutionDuration).HasColumnType("decimal(18, 0)");

            //    entity.HasOne(d => d.IssueClassification)
            //        .WithMany(p => p.DevelopmentIssues)
            //        .HasForeignKey(d => d.IssueClassificationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__Developme__Issue__34C8D9D1");

            //    entity.HasOne(d => d.IssueSeverity)
            //        .WithMany(p => p.DevelopmentIssues)
            //        .HasForeignKey(d => d.Severity)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__Developme__Sever__29572725");

            //    entity.HasOne(d => d.Status)
            //        .WithMany(p => p.DevelopmentIssues)
            //        .HasForeignKey(d => d.StatusId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__Developme__Statu__286302EC");
            //});

            //modelBuilder.Entity<IssueAttachment>(entity =>
            //{
            //    entity.ToTable("IssueAttachment");

            //    entity.Property(e => e.AttachmentId)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.HasOne(d => d.AttachmentType)
            //        .WithMany(p => p.IssueAttachments)
            //        .HasForeignKey(d => d.AttachmentTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__IssueAtta__Attac__31EC6D26");

            //    entity.HasOne(d => d.Issue)
            //        .WithMany(p => p.IssueAttachments)
            //        .HasForeignKey(d => d.IssueId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__IssueAtta__Issue__30F848ED");
            //});

            //modelBuilder.Entity<IssueAttachmentType>(entity =>
            //{

            //    entity.ToTable("IssueAttachmentType");

            //    entity.Property(e => e.AttachmentType)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<IssueClassification>(entity =>
            //{
            //    entity.ToTable("IssueClassification");

            //    entity.Property(e => e.Classification)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<IssueDetail>(entity =>
            //{
            //    entity.ToTable("IssueDetail");

            //    entity.HasOne(d => d.Issue)
            //        .WithMany(p => p.IssueDetails)
            //        .HasForeignKey(d => d.IssueId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__IssueDeta__Issue__2C3393D0");
            //});

            //modelBuilder.Entity<IssueSeverity>(entity =>
            //{
            //    entity.ToTable("IssueSeverity");

            //    entity.Property(e => e.Severity)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<IssueStatus>(entity =>
            //{
            //    entity.ToTable("IssueStatus");

            //    entity.Property(e => e.Status)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.SetAuditProperties();
            return await base.SaveChangesAsync(cancellationToken);
        }
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ChangeTracker.SetAuditProperties();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override int SaveChanges()
        {
            ChangeTracker.SetAuditProperties();
            return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ChangeTracker.SetAuditProperties();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
    }
