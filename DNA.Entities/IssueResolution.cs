using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Entities
{
    public class IssueResolution : EntityBase
    {
        public string Content { get; set; }
        public User PostedBy { get; set; }
        public DateTime DateOfPost { get; set; }

    }
}
