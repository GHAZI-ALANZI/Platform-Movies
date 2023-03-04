using Microsoft.AspNetCore.Identity;

namespace Platform_Movies.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
