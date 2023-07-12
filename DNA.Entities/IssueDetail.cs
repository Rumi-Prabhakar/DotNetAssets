using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class IssueDetail : EntityBase
    {
        public int IssueId { get; set; }
        public string IssueDescription { get; set; } = null!;

        public virtual DevelopmentIssue Issue { get; set; } = null!;
    }
}
