using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class IssueStatus : EntityBase
    {
        public IssueStatus()
        {
            DevelopmentIssues = new HashSet<DevelopmentIssue>();
        }

        public string Status { get; set; } = null!;

        public virtual ICollection<DevelopmentIssue> DevelopmentIssues { get; set; }
    }
}
