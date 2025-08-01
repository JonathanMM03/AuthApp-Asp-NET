using Microsoft.AspNetCore.Identity;

namespace JwtAuth.Models
{
    public class AppUser : IdentityUser
    {
        public string? Fullname { get; set; }

    }
}
