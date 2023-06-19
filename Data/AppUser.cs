using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace MnsGames.Data
{
    public class AppUser : IdentityUser
    {
        public int Id { get; set; }

        public string? LoginNickname { get; set; }

        public string? LoginPassword { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [DefaultValue(false)]
        public bool IsAdmin { get; set; }

        public string? StreetNumber { get; set; }

        public string? StreetName { get; set; }

        public string? Zipcode { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

    }
}
