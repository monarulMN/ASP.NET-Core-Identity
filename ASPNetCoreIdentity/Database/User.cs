using Microsoft.AspNetCore.Identity;

namespace ASPNetCoreIdentity.Database
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
