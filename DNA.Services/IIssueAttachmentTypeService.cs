using DNA.Shared;

namespace DNA.Services
{
    public interface IIssueAttachmentTypeService
    {
        Task<IEnumerable<IssueAttachmentTypeDto>> GetAllIssueAttachmentTypes(bool trackChanges, PaginationParameters pageParameters);
        Task<IssueAttachmentTypeDto> GetIssueAttachmentTypeById(int Id);
        Task<IssueAttachmentTypeDto> CreateIssueAttachmentType(IssueAttachmentTypeCreateDto type);
    }
}
