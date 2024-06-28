using Microsoft.AspNetCore.Identity;

namespace API.Models

{
    public class AppUser : IdentityUser
    {
        public String? Fullname { get; set; }



    }
}