using DNA.Entities;
using DNA.Shared;

    public interface IIssueAttachmentTypeRepository
    {
        Task<IEnumerable<IssueAttachmentType>> GetAllIssueAttachmentTypes(bool trackChanges, PaginationParameters pageParameters);
        Task<IssueAttachmentType> GetIssueAttachmentTypeById(int Id);    
        Task<IssueAttachmentType> CreateIssueAttachmentType(IssueAttachmentTypeCreateDto type);
    }

