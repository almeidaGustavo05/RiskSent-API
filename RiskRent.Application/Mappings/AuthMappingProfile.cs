using AutoMapper;
using RiskRent.Application.Features.Auth.DTOs;
using RiskRent.Application.Features.Auth.Commands;
using RiskRent.Domain.Entities;

namespace RiskRent.Application.Mappings
{
    public class AuthMappingProfile : Profile
    {
        public AuthMappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<LoginDto, LoginCommand>()
                .ConstructUsing(src => new LoginCommand(src.Email, src.Password));
        }
    }
}