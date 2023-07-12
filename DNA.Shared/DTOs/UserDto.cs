namespace DNA.Shared
{
    public record UserDto
    (
        Guid UserId,
        string UserName,
        string PreferredName,
        string FirstName,
        string LastName,
        string FullName,
        string EmailAddress
    );

    public record UserIdentityDto
    (
        bool IsAuthenticated,
        string UserId,
        string Username,
        string EmailAddress
    );
}