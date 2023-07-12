using DNA.Entities;
using DNA.Shared;
using Microsoft.EntityFrameworkCore;

namespace DNA.Repository.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        private DotNetAssetsContext _dotNetAssetsContext;
        public RoleRepository(DotNetAssetsContext dotNetAssetsContext) : base(dotNetAssetsContext)
        {
            _dotNetAssetsContext = dotNetAssetsContext;
        }

        public async Task<IEnumerable<RoleDto>> GetAllRoles(bool trackChanges, PaginationParameters pageParameters)
        {
            return await FindAll(trackChanges)
                .Select(r => r.MapToRoleDto())
                .Skip((pageParameters.PageNumber -1)* pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .ToListAsync();
        }
        public async Task<RoleDto> CreateRole(RoleCreateDto roleCreateDto)
        {
            var roleEntity = roleCreateDto.MapToRole();
            await _dotNetAssetsContext.Role.AddAsync(roleEntity);
            await _dotNetAssetsContext.SaveChangesAsync();
            return roleEntity.MapToRoleDto();
        }

        public async Task<Role> GetRoleById(int id)
        {
            return await FindByCondition(r => r.Id == id);
        }

        public async Task DeactiveRole(RoleDto roleDto)
        {
            _dotNetAssetsContext.Role.Update(roleDto.MapToRole());
            await _dotNetAssetsContext.SaveChangesAsync();
        }
    }
}
