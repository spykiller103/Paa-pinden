using PaaPinden.Data;

namespace PaaPinden.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public int? PindId { get; set; }
        public Pind? Pind { get; set; }

        public int? RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
