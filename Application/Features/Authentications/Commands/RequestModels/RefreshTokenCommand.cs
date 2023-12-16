using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Auth.Commands.RequestModels
{
    public class RefreshTokenCommand : IRequest<LoginDTO>
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        
    }
}