using MediatR;
using RiskRent.Application.Features.Auth.DTOs;

namespace RiskRent.Application.Features.Auth.Queries
{
    public class GetCurrentUserQuery : IRequest<UserDto>
    {
        public int UserId { get; set; }

        public GetCurrentUserQuery(int userId)
        {
            UserId = userId;
        }
    }
}