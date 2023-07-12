using DNA.Repository.Repositories;

public class RepositoryManager : IRepositoryManager
{   
        private readonly DotNetAssetsContext dotNetAssetsContext;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IIssueAttachmentTypeRepository> _issueAttachmentTypeRepository;
        private readonly Lazy<IRoleRepository> _roleRepository;

        public RepositoryManager(DotNetAssetsContext dotnetAssetsContext)
        {
            dotNetAssetsContext = dotnetAssetsContext;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(dotnetAssetsContext));
            _issueAttachmentTypeRepository
                       = new Lazy<IIssueAttachmentTypeRepository>(() => new IssueAttachmentTypeRepository(dotnetAssetsContext));
            _roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(dotnetAssetsContext));
        }

        public IUserRepository User => _userRepository.Value;
        public IIssueAttachmentTypeRepository IssueAttachmentType => _issueAttachmentTypeRepository.Value;
        public IRoleRepository Role => _roleRepository.Value;
        public void Save() => dotNetAssetsContext.SaveChanges();
    }
