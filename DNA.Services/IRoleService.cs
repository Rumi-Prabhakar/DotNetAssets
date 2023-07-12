using DNA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA.Services
{
    public interface IRoleService
    {
        Task<RoleDto> GetRoleById(int Id);
        Task<IEnumerable<RoleDto>> GetAllRoles(bool trackChanges, PaginationParameters pageParameters);
        Task<RoleDto> CreateRole(RoleCreateDto roleCreateDto);
        Task DeactivateRole(RoleDto roleDto);
    }
}
