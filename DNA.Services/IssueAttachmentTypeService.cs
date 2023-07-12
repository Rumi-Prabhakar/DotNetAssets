using AutoMapper;
using DNA.Logger;
using DNA.Shared;

namespace DNA.Services
{
    public class IssueAttachmentTypeService : IIssueAttachmentTypeService
    {
        private IRepositoryManager _repositoryManager;
        private INLogManager _logManager;
        private readonly IMapper _mapper;


        public IssueAttachmentTypeService(IRepositoryManager repositoryManager, INLogManager logManager, IMapper mapper)
        { 
            _repositoryManager = repositoryManager;
            _logManager = logManager;
            _mapper = mapper;
        }

        public async Task<IssueAttachmentTypeDto> CreateIssueAttachmentType(IssueAttachmentTypeCreateDto issueAttachmentTypeCreateDto)
        {
            var issueAttachmentType = await _repositoryManager.IssueAttachmentType.CreateIssueAttachmentType(issueAttachmentTypeCreateDto);
            return issueAttachmentType.MapToIssueAttachmentTypeDto();
        }

        public async Task<IEnumerable<IssueAttachmentTypeDto>> GetAllIssueAttachmentTypes(bool trackChanges, PaginationParameters pageParameters)
        {
            var issueAttachmentTypes = await _repositoryManager
                        .IssueAttachmentType
                        .GetAllIssueAttachmentTypes(trackChanges, pageParameters);

            return issueAttachmentTypes.Select(i => i.MapToIssueAttachmentTypeDto());
        }

        public async Task<IssueAttachmentTypeDto> GetIssueAttachmentTypeById(int Id)
        {
            var issueAttachmentType =  await _repositoryManager
                         .IssueAttachmentType
                         .GetIssueAttachmentTypeById(Id);

            return issueAttachmentType.MapToIssueAttachmentTypeDto();                         
        }
    }
}
