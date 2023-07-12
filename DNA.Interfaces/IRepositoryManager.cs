    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IRoleRepository Role { get; }
        IIssueAttachmentTypeRepository IssueAttachmentType { get; }
        void Save();
    }
