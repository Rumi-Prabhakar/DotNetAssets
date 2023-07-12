using DNA.Entities;
using DNA.Shared;
public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers(bool trackChanges, PaginationParameters pageParameters);
        Task<User> GetUserById(Guid Id);
        Task<User> GetUserByUserName(string username);
        Task<User> CreateUser(UserCreateDto user, string passwordSalt, string passwordHash);        
    }
