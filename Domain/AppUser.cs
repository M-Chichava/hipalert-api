using Microsoft.AspNetCore.Identity;

namespace Domain;

public class AppUser : IdentityUser
{
        public int Id { get; set; }
        public string FullName { get; set; }
        public Role Role { get; set; }
}