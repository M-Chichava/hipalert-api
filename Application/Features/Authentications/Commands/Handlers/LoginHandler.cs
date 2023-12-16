using System.Net;
using Application.DTOs;
using Application.Features.Authentications.Commands.RequestModels;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Features.Authentications.Commands.Handlers;

public class LoginHandler : IRequestHandler<LoginCommand,LoginDTO>
{
    private readonly SignInManager<AppUser> _signInManager;
    private readonly UserManager<AppUser> _userManager;
    private readonly IJwtGenerator _jwtGenerator;
    private readonly DataContext _context;

    public LoginHandler(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator, DataContext context)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _jwtGenerator = jwtGenerator;
        _context = context;
    }
    public async Task<LoginDTO> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.Users
            .Where(x => x.Email == request.Email)
            .Include(x=>x.Role)
            .FirstOrDefaultAsync();
        var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        if (result.Succeeded)
        {
            var authInfo = await _jwtGenerator.GenerateToken(user, false);
            
            return  new LoginDTO
            {
                Email = user.Email,
                Token =  authInfo.Token,
                RefreshToken = authInfo.RefreshToken.Token,
                Username = user.UserName,
                FullName = user.FullName,
                Role = new RoleAdapter
                {
                    Description = user.Role.Description,
                    Name = user.Role.Name,
                    Permissions = await _context.RolePermissions
                        .Include(x=>x.Role)
                        .Include(x=>x.Permission)
                        .Where(x=>x.Role.Id == user.Role.Id)
                        .Select(x=>x.Permission)
                        .ToListAsync()
                            
                            
                }
            };
        }

        throw new WebException("Login Failed", (WebExceptionStatus)HttpStatusCode.InternalServerError);
    }
}