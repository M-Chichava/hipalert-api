using Domain;

namespace Application.DTOs;

public class RoleAdapter
{
    public string Description { get; set; }
    public string Name { get; set; }
    public List<Permission> Permissions { get; set; }
}

public class LoginDTO
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public RoleAdapter Role { get; set; }
}