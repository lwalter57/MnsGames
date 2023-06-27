namespace MnsGames.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public bool IsCorrect { get; set; }
        public int Points { get; set; }
        public int NextQuestionId { get; set; }

    }
}
