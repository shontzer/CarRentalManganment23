using Microsoft.AspNetCore.Identity;

namespace CarRentalManganment23.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String? FirstName { get; set; }
        public String? LastName { get; set;}
    }
}
