using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Errors;
using Application.Features.Auth.Commands.RequestModels;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Features.Auth.Commands.Handlers
{
    public class RefreshTokenHandler : IRequestHandler<RefreshTokenCommand, LoginDTO>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly DataContext _context;
        private readonly UserManager<AppUser> _userManager;

        public RefreshTokenHandler(IJwtGenerator jwtGenerator, DataContext context, UserManager<AppUser> userManager)
        {
            _jwtGenerator = jwtGenerator;
            _context = context;
            _userManager = userManager;
        }
        public async Task<LoginDTO> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            
            var storedToken = await _context.RefreshTokens.Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Token == request.RefreshToken);
            
            if (storedToken == null) throw new ApiException(HttpStatusCode.BadRequest, 
                "Token is not valid (DB)");
            
            
            if (storedToken.Invalidated)
                throw new ApiException(HttpStatusCode.BadRequest, "Token is not valid (Invalidated)");
            var tokenIsRefreshTokenIsValid = await _jwtGenerator.VerifyTokenValidity(
                new RefreshTokenDTO
                {
                    Token = request.Token,
                    RefreshToken = request.RefreshToken
                
                }, storedToken);
            if (!tokenIsRefreshTokenIsValid) throw new ApiException(HttpStatusCode.BadRequest, 
                "Token is not valid");

            var refreshedToken =  await _jwtGenerator.GenerateToken(storedToken.User, true);
            return new LoginDTO
            {
                Token = refreshedToken.Token,
                RefreshToken = refreshedToken.RefreshToken?.Token,
                Email = storedToken.User?.Email,
                Username = storedToken.User?.UserName,
                FullName = storedToken.User?.FullName
                
            };

        }
    }
}