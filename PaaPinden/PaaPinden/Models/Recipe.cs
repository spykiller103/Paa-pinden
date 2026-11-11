using PaaPinden.Data;

namespace PaaPinden.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public byte[] MediaType { get; set; }
        public string Category { get; set; }
        public DateTime PostDate { get; set; }
        public int Like { get; set; }

        public string Title { get; set; }
        public TimeOnly TimeUsage { get; set; }
        public string Mask { get; set; }
        public double KnittingNeedleSize { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int CommentId { get; set; }
        public List<Comment> Comments { get; set; } = new();
    }
}
