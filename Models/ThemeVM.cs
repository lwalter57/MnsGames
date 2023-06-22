using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace MnsGames.Models
{
    public class ThemeVM
    {
        public int Id { get; set; }
        [Display(Name = "Theme name")]
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
