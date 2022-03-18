using MediatR;
using VolunteerPointApp.Application.User.AddUser;

namespace VolunteerPointApp.Api.Controllers.v1;

public class UserController : BaseController
{
  private readonly ILogger<UserController> _logger;
  private readonly IMediator _mediator;
  
  public UserController(ILogger<UserController> logger, IMediator mediator)
  {
    _logger = logger;
    _mediator = mediator;
  }

  [HttpPost]
  public async Task<ActionResult> AddUser(string username, string password)
  {
    try
    {
      var result = await _mediator.Send(new AddUserCommand(username, password));
      if (result.HasError)
      {
        return new BadRequestObjectResult(new { errorMessage = result.Error });
      }

      return new OkResult();
    }
    catch(Exception ex)
    {
      _logger.LogError(ex, "Failed to create new user with username: {Username}", username);
      return new StatusCodeResult(500);
    }
  }
}
