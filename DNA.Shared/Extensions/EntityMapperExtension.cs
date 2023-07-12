using DNA.Entities;
using DNA.Shared;

namespace DNA.Shared
{
    public static class EntityMapperExtension
    {
        public static IssueAttachmentType MapToIssueAttachmentType(this IssueAttachmentTypeCreateDto attachmentType)
        {
            return new IssueAttachmentType
            {
                AttachmentType = attachmentType.AttachmentType,
                IsDeleted = attachmentType.isDeleted
            };
        }

        public static DNA.Shared.IssueAttachmentTypeDto MapToIssueAttachmentTypeDto(this IssueAttachmentType attachmentType)
        {
            return new IssueAttachmentTypeDto(attachmentType.Id, attachmentType.AttachmentType, attachmentType.IsDeleted);
        }

        public static User MapToUser(this UserCreateDto user)
        {
            return new User
            {
                UserId = user.UserId,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PreferredName = user.PreferredName,
                EmailAddress = user.EmailAddress
            };
        }

        public static UserDto MapToUserDto(this User user)
        {
            return new UserDto(
                               user.UserId,
                               user.UserName,
                               user.PreferredName,
                               user.FirstName, user.LastName,
                               user.FirstName + " " + user.LastName,
                               user.EmailAddress);
        }


        public static Role MapToRole(this RoleCreateDto roleCreateDto)
        {
            return new Role
            {
                RoleName = roleCreateDto.RoleName,
                IsDeleted = roleCreateDto.isDeleted,
                CreationDateTime = roleCreateDto.CreatedDateTime,
                ModifiedDateTime = roleCreateDto.ModifiedDateTime
            };
        }

        public static Role MapToRole(this RoleDto roleDto)
        {
            return new Role
            {
                RoleName = roleDto.RoleName,
                IsDeleted = !roleDto.isActive,
                CreationDateTime = roleDto.CreatedDatetime,
                ModifiedDateTime = roleDto.ModifiedDatetime
            };
        }
        public static RoleDto MapToRoleDto(this Role role)
        {
            return new RoleDto(
                                role.Id,
                                role.RoleName,
                                !role.IsDeleted,
                                role.CreationDateTime,
                                role.ModifiedDateTime);
        }

        
    }
}
