using DNA.Entities;
using DNA.Shared;
    public  interface IRoleRepository
    {
        Task<IEnumerable<RoleDto>> GetAllRoles(bool trackChanges, PaginationParameters pageParameters);
        Task<Role> GetRoleById(int id);
        Task<RoleDto> CreateRole(RoleCreateDto roleCreateDto);
        Task DeactiveRole(RoleDto roleDto);
    }
