using DNA.Entities;
using DNA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUserById(Guid Id);
        Task<IEnumerable<UserDto>> GetAllUsers(bool trackChanges, PaginationParameters pageParameters);
        Task<UserDto> CreateUser(UserCreateDto userCreateDto);
        Task<UserIdentityDto> VerifyUser(string username, string password);

    }
}
