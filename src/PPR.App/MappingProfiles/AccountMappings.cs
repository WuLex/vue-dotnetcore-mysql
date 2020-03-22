using AutoMapper;
using PPR.App.DTOs;
using PPR.App.DTOs.User;
using PPR.Common.Entities;

namespace PPR.App.MappingProfiles
{
    public class AccountMappings : Profile
    {
        public AccountMappings()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserCreateDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();
        }
    }
}