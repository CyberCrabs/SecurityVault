using Microsoft.AspNetCore.Mvc;
using SecurityVault.Api.Dtos.AuthDtos;
using SecurityVault.Core.Features.User.Records;
using SecurityVault.Core.Interfaces.Services;
using MediatR;
namespace SecurityVault.Api.Controllers;

public class AuthControllers(IUserService userService,IMediator mediator) : BaseController
{
    [HttpPost("register")]
    public async Task<ActionResult> RegisterUser(RegisterDto dto,CancellationToken ct)
    {
        var query = new RegisterRecord(dto.Username,dto.Email,dto.Password);
        var result = await mediator.Send(query,ct);

        if (!result.IsSuccess) return HandleError(result);
        return Ok(result); 
        
    }
}