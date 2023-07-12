using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class IssueSeverity : EntityBase
    {
        public IssueSeverity()
        {
            DevelopmentIssues = new HashSet<DevelopmentIssue>();
        }

        public string Severity { get; set; } = null!;

        public virtual ICollection<DevelopmentIssue> DevelopmentIssues { get; set; }
    }
}
