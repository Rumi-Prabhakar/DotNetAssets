using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class IssueAttachment :EntityBase
    {        
        public int IssueId { get; set; }
        public string AttachmentId { get; set; } = null!;
        public int AttachmentTypeId { get; set; }

        public virtual IssueAttachmentType AttachmentType { get; set; } = null!;
        public virtual DevelopmentIssue Issue { get; set; } = null!;
    }
}
