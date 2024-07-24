using CleanArchitectrure.Application.Interface.Persistence;
using MassTransit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectrure.Application.UseCases.Users.Queries.GetAll
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, GetAllUsersResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IPublishEndpoint _publishEndpoint;

        public GetAllUsersHandler(IUnitOfWork unitOfWork,
                                  IUserRepository userRepository,
                                  IPublishEndpoint publishEndpoint)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _publishEndpoint = publishEndpoint;
        }


        public async Task<GetAllUsersResponse> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
