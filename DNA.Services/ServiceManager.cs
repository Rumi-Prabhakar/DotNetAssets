using DNA.Entities;
using DNA.Logger;
using AutoMapper;

namespace DNA.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepositoryManager _repositoryManager ;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IIssueAttachmentTypeService> _issueAttachmentTypeService;
        public ServiceManager(DotNetAssetsContext dotNetAssetsContext,
                                INLogManager nLogManager,
                                IMapper mapper)
        {
            _repositoryManager = new RepositoryManager(dotNetAssetsContext);
            _userService = new Lazy<IUserService>(() => new UserService(_repositoryManager, nLogManager, mapper));
            _issueAttachmentTypeService = new Lazy<IIssueAttachmentTypeService>(() => new IssueAttachmentTypeService(_repositoryManager, nLogManager, mapper));
        }
        public IUserService UserService => _userService.Value;
        public IIssueAttachmentTypeService IssueAttachmentTypeService => _issueAttachmentTypeService.Value;
    }
}
