using AutoMapper;
using DNA.Logger;
using DNA.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;

namespace DNA.Services
{
    public class UserService : IUserService
    {
        private IRepositoryManager _repositoryManager;
        private INLogManager _logManager;
        public UserService(IRepositoryManager repositoryManager, INLogManager nLogManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logManager = nLogManager;
        }

        public async Task<UserDto> GetUserById(Guid userId)
        {
            var user = await _repositoryManager.User.GetUserById(userId);
            return user == null ? throw new KeyNotFoundException()
                          : user.MapToUserDto();
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers(bool trackChanges, PaginationParameters pageParameters)
        {
            try
            {              
                var users = await _repositoryManager.User.GetAllUsers(trackChanges, pageParameters);

                var userDtos = users.Select(u => u.MapToUserDto());
                return userDtos;
            }
            catch (Exception ex)
            {
                _logManager.LogError($"Error in {nameof(GetAllUsers)} , exception :{ex}");
                throw;
            }
        }

        public async Task<UserDto> CreateUser(UserCreateDto userCreateDto)
        {
            string passwordSalt, passwordHash;
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = Convert.ToBase64String(hmac.Key);
                passwordHash = Convert.ToBase64String(
                hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(userCreateDto.Password)));
            }
            var user = await _repositoryManager.User.CreateUser(userCreateDto, passwordSalt, passwordHash);
            return user.MapToUserDto();
        }

        public async Task<UserIdentityDto> VerifyUser(string username, string password)
        {           

            var user = await _repositoryManager.User.GetUserByUserName(username);
            byte[] passwordSalt = Convert.FromBase64String(user.PasswordSalt);
            byte[] passwordHash = Convert.FromBase64String(user.PasswordHash);
            byte[] enteredPasswordHash;
            using (HMACSHA512 hmac = new HMACSHA512(passwordSalt))
            {
                enteredPasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            return (passwordHash.SequenceEqual(enteredPasswordHash) == true)
                   ? new UserIdentityDto(true, user.UserId.ToString(), user.UserName, user.EmailAddress)
                   : new UserIdentityDto(false, null, null, null) ;
        }
    }
}
