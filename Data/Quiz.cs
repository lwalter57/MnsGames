using System.ComponentModel.DataAnnotations.Schema;

namespace MnsGames.Data
{
    public class Quiz
    {
        public int Id { get; set; }
        public string QuizName { get; set; }
        public TimeSpan? Duration { get; set; }
        public int AppUserId { get; set; }

        [ForeignKey("ThemeId")]
        public Theme Theme { get; set; }
        public int ThemeId { get; set; }

    }
}
