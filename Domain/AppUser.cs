using Microsoft.AspNetCore.Identity;

namespace Domain;

public class AppUser : IdentityUser
{
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public Role Role { get; set; }
}