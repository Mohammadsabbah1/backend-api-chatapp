using Microsoft.AspNetCore.Identity;

namespace WebApplication5.Models
{
    public class User: IdentityUser
    {
        public string UserName { get; set; }
        public bool IsActive { get; set; } // Add this property

        public bool IsAdmin { get; set; }

    }
}
