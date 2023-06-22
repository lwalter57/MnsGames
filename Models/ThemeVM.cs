using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace MnsGames.Models
{
    public class ThemeVM
    {
        [Display(Name = "Theme name")]
        [Required]
        public string Name { get; set; }
    }
}
