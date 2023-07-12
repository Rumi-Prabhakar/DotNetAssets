namespace DNA.Shared
{
    public class UserCreateDto
    {        
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string PreferredName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
