using AutoMapper;
using MediatR;
using RiskRent.Application.Features.Auth.DTOs;
using RiskRent.Application.Exceptions;
using RiskRent.Domain.Interfaces;

namespace RiskRent.Application.Features.Auth.Queries
{
    public class GetCurrentUserQueryHandler : IRequestHandler<GetCurrentUserQuery, UserDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCurrentUserQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(request.UserId);
            
            if (user == null)
                throw new UserNotFoundException(request.UserId);

            return _mapper.Map<UserDto>(user);
        }
    }
}