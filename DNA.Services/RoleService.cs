using DNA.Logger;
using DNA.Shared;

namespace DNA.Services
{
    public class RoleService : IRoleService
    {
        private IRepositoryManager _repositoryManager;
        private INLogManager _logManager;

        public RoleService(IRepositoryManager repositoryManager, INLogManager logManager) 
        {
            _repositoryManager = repositoryManager;
            _logManager = logManager;
        }
        public async Task<RoleDto> GetRoleById(int id)
        {
            var role = await _repositoryManager.Role.GetRoleById(id);
            return (role == null) ? throw new KeyNotFoundException() :
                    role.MapToRoleDto(); 
        }

        public async Task<IEnumerable<RoleDto>> GetAllRoles(bool trackChanges, PaginationParameters pageParameters)
        {
            return await _repositoryManager.Role.GetAllRoles(trackChanges, pageParameters);
        }

        public async Task<RoleDto> CreateRole(RoleCreateDto roleCreateDto)
        {
            return await _repositoryManager.Role.CreateRole(roleCreateDto);
        }

        public async Task DeactivateRole(RoleDto roleDto)
        { 
            await _repositoryManager.Role.DeactiveRole(roleDto);
        }
    }
}
