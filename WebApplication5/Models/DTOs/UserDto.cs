using Microsoft.AspNetCore.Identity;

namespace WebApplication5.Models.DTOs

{
    public class UserDto:IdentityUser
    {
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
    }
}

