namespace PaaPinden.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public int? PindId { get; set; }
        public Pind? Pind { get; set; }

        public int? RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
