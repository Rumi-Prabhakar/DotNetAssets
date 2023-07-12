using System;
using System.Collections.Generic;

namespace DNA.Entities
{
    public partial class IssueAttachmentType : EntityBase
    {
        public IssueAttachmentType()
        {
            IssueAttachments = new HashSet<IssueAttachment>();
        }

        public string AttachmentType { get; set; } = null!;

        public virtual ICollection<IssueAttachment> IssueAttachments { get; set; }
    }
}
