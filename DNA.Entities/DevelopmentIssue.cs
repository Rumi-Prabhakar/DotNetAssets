using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class DevelopmentIssue : EntityBase
    {
        public DevelopmentIssue()
        {
            IssueAttachments = new HashSet<IssueAttachment>();
            IssueDetails = new HashSet<IssueDetail>();
        }

        public string IssueTitle { get; set; } = null!;
        public int IssueClassificationId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public int StatusId { get; set; }
        public int Severity { get; set; }
        public decimal? ResolutionDuration { get; set; }

        public virtual IssueClassification IssueClassification { get; set; } = null!;
        public virtual IssueSeverity IssueSeverity { get; set; } = null!;
        public virtual IssueStatus Status { get; set; } = null!;
        public virtual ICollection<IssueAttachment> IssueAttachments { get; set; }
        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
    }
}
