using MediatR;
using VolunteerPointApp.Application.Models;

namespace VolunteerPointApp.Application.User.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, OperationResult<Unit>>
{
  public AddUserCommandHandler()
  {
  }

  public Task<OperationResult<Unit>> Handle(AddUserCommand request, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}
