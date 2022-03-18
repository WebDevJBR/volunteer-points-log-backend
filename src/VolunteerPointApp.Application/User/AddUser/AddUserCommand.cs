using MediatR;
using VolunteerPointApp.Application.Models;

namespace VolunteerPointApp.Application.User.AddUser;

public class AddUserCommand : IRequest<OperationResult<Unit>>
{
  public string Username { get; }
  public string Password { get; }

  public AddUserCommand(string username, string password)
  {
    Username = username;
    Password = password;
  }
}
