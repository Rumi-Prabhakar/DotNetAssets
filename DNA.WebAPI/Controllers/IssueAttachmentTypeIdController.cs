using DNA.Logger;
using DNA.Services;
using DNA.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNA.WebAPI.Controllers
{
    [Route("api/IssueAttachmentType")]
    [ApiController]
    public class IssueAttachmentTypeIdController : ControllerBase
    {
        IServiceManager _serviceManager;
        INLogManager _logManager;
        public IssueAttachmentTypeIdController(IServiceManager serviceManager, INLogManager nLogManager)
        {
            _serviceManager = serviceManager;
            _logManager = nLogManager;
        }

        [HttpGet(Name = "GetAllIssueAttachmentTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IssueAttachmentTypeDto>))]
        public async Task<IActionResult> GetAllIssueAttachmentTypes([FromQuery]PaginationParameters pageParameters, [FromQuery]bool trackChanges = false)
        {
            var result = await _serviceManager.IssueAttachmentTypeService.GetAllIssueAttachmentTypes(trackChanges, pageParameters);
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetIssueAttachmentTypeById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IssueAttachmentTypeDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ActionName(nameof(GetIssueAttachmentTypeById))]
        public async Task<IActionResult> GetIssueAttachmentTypeById(int id)
        {
            var result = await _serviceManager.IssueAttachmentTypeService.GetIssueAttachmentTypeById(id);
            return (result == null) ? NotFound() : Ok(result);
        }

        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type= typeof(IssueAttachmentTypeDto))]
        public async Task<IActionResult> Post([FromBody] IssueAttachmentTypeCreateDto issueAttachmentTypeCreateDto)
        {
            var issueAttachmentTypeDto = await _serviceManager.IssueAttachmentTypeService.CreateIssueAttachmentType(issueAttachmentTypeCreateDto);
            var actionName = nameof(GetIssueAttachmentTypeById);
            var routeValue = new { id = issueAttachmentTypeDto.Id };
            return CreatedAtAction(actionName, routeValue, issueAttachmentTypeDto);
        }
        
    }
}
