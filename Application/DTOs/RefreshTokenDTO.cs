using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class RefreshTokenDTO
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string RefreshToken { get; set; }
    }
}