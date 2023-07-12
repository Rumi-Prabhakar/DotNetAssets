using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Shared
{
    public class IssueAttachmentTypeCreateDto
    {
        public string AttachmentType { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
