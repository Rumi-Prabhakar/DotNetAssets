using DNA.Logger;
using DNA.Services;
using DNA.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNA.WebAPI.Controllers
{
    [Authorize]
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        INLogManager _logManager;
        public UserController(IUserService userService, INLogManager nLogManager) 
        {
            _userService = userService;
            _logManager = nLogManager;
        }

        
        
        [HttpGet(Name ="GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserDto>))]
        public async Task<IActionResult> GetAllUsers([FromQuery] bool trackChanges, [FromQuery] PaginationParameters pageParameters)
        {
            _logManager.LogInfo($"{GetType().FullName}.{MethodBase.GetCurrentMethod().Name} started");
            var result = await _userService.GetAllUsers(trackChanges, pageParameters);
            _logManager.LogInfo($"{GetType().FullName}.{MethodBase.GetCurrentMethod().Name} ended");
            return Ok(result);
        }

        
        [HttpGet("{id}", Name = "GetUserById")]
        [ActionName(nameof(GetUserById))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var result = await _userService.GetUserById(id);
                        return (result == null)? NotFound() : Ok(result);
        }

        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserDto))]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDto userCreateDto)
        {
            var userDto = await _userService.CreateUser(userCreateDto);

            var actionName = nameof(GetUserById);
            var routeValue = new {id = userDto.UserId};
            return CreatedAtAction(actionName, routeValue, userDto);            
        }        
        
    }
}
