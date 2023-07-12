using DNA.Shared;
using DNA.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    private DotNetAssetsContext _dotNetAssetsContext;
    public UserRepository(DotNetAssetsContext dotNetAssetsContext) : base(dotNetAssetsContext)
    {
        _dotNetAssetsContext = dotNetAssetsContext;
    }

    public async Task<IEnumerable<User>> GetAllUsers(bool trackChanges, PaginationParameters pageParameters)
    {
        return await FindAll(trackChanges)
       .OrderBy(u => u.FirstName)
       .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
       .Take(pageParameters.PageSize)
       .ToListAsync<User>();
    }
    public async Task<User> GetUserById(Guid userId)
    {
        return await FindByCondition(user => user.UserId == userId);
    }

    public async Task<User> GetUserByUserName(string username)
    {
        return await FindByCondition(user => user.UserName == username);
    }
    public async Task<User> CreateUser(UserCreateDto userCreateDto, string passwordSalt, string passwordHash) 
    {
        var user = userCreateDto.MapToUser();
        user.PasswordSalt = passwordSalt;
        user.PasswordHash = passwordHash;
        await _dotNetAssetsContext.User.AddAsync(user);
        await _dotNetAssetsContext.SaveChangesAsync();
        return user;
    }

}
