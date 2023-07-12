using DNA.Entities;
using DNA.Shared;
using Microsoft.EntityFrameworkCore;
using System.Net;

public class IssueAttachmentTypeRepository: RepositoryBase<IssueAttachmentType>, IIssueAttachmentTypeRepository
    {
        private DotNetAssetsContext _dotNetAssetsContext;
        public IssueAttachmentTypeRepository(DotNetAssetsContext dotNetAssetsContext) : base(dotNetAssetsContext)
        {
            _dotNetAssetsContext = dotNetAssetsContext;
        }
    
        public async Task<IssueAttachmentType> CreateIssueAttachmentType(IssueAttachmentTypeCreateDto attachmentTypeCreateDto)
        {
        
            var issueAttachmentType = attachmentTypeCreateDto.MapToIssueAttachmentType();
            await _dotNetAssetsContext.IssueAttachmentTypes.AddAsync(issueAttachmentType);
            await _dotNetAssetsContext.SaveChangesAsync();
            return issueAttachmentType;
        }

        //Returning the entire List of Entities is a security breach and often called an unbounded query
        //result of a 'GetAll' method, therefore includes pagination to send out a set amount of items per request
        //The GetAllIssueAttachmentTypes therefore doesnot need to be asynchronous, and returns an IEnumerable<IssueAttachmentTypeDto>
        public async Task<IEnumerable<IssueAttachmentType>> GetAllIssueAttachmentTypes(bool trackChanges, PaginationParameters pageParameters)
        {
            return await FindAll(trackChanges)
                  .Skip((pageParameters.PageNumber-1) * pageParameters.PageSize)
                  .Take(pageParameters.PageSize)
                  .ToListAsync();
        }
        

        public async Task<IssueAttachmentType> GetIssueAttachmentTypeById(int Id)
        {
            return await FindByCondition(a => a.Id == Id);
        }
}
