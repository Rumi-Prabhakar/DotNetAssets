namespace DNA.Shared
{
    public record RoleDto
    (
        int Id,
        string RoleName,
        bool isActive,
        DateTime CreatedDatetime,
        DateTime ModifiedDatetime
    );
    
}
