using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace MnsGames.Data
{
    public class AppUser : IdentityUser
    {

        public string? Nickname { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string? StreetNumber { get; set; }

        public string? StreetName { get; set; }

        public string? Zipcode { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

    }
}
