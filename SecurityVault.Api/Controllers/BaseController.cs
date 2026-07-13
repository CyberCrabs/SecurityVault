using Microsoft.AspNetCore.Mvc;
using SecurityVault.Core.Wrappers;

namespace SecurityVault.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
    protected ActionResult HandleError(Result result)
    {
        if (result.Errors != null && result.Errors.Any())
        {
            return BadRequest(new { Error = result.Errors });
        } 

        return BadRequest(result.ErrorMessage);
    }
}