using AutoMapper;
using DNA.Entities;
using DNA.Shared;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DNA.WebAPI
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                   .ForMember(dest => dest.FullName,
                   src => src.MapFrom(src => src.FirstName + " " + src.LastName));
        }
    }
}
