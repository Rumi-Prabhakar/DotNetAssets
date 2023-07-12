using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Services
{
    public interface IServiceManager
    {
       IIssueAttachmentTypeService IssueAttachmentTypeService { get; }
       IUserService UserService { get; }
    }
}
