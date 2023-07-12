using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class IssueClassification : EntityBase
    {
        public IssueClassification()
        {
            DevelopmentIssues = new HashSet<DevelopmentIssue>();
        }

        public string Classification { get; set; } = null!;

        public virtual ICollection<DevelopmentIssue> DevelopmentIssues { get; set; }
    }
}
