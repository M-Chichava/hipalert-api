using Application.DTOs;
using Application.Features.Authentications.Commands.RequestModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AuthController : BaseController
{
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<ActionResult<LoginDTO>> Login(LoginCommand command)
    {
        return await Mediator.Send(command);
    }
    
}