using Application.DTOs;
using MediatR;

namespace Application.Features.Authentications.Commands.RequestModels;

public class LoginCommand : IRequest<LoginDTO>
{
    public string Email { get; set; }
    public string Password { get; set; }
}