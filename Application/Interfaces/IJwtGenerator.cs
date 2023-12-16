using System.Threading.Tasks;
using Application.Dtos;
using Application.DTOs;
using Domain;

namespace Application.Interfaces
{
    public interface IJwtGenerator
    {
       Task<TokenAdapter> GenerateToken(AppUser user, bool updateExistingToken);
       Task<bool> VerifyTokenValidity(RefreshTokenDTO refreshTokenDTO, RefreshToken refreshToken);
    }
}