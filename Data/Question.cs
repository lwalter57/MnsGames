namespace MnsGames.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string LabelQuestion { get; set; }
        public TimeSpan? Duration { get; set; }
        public int QuizId { get; set; }
    }
}
