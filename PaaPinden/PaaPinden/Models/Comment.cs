namespace PaaPinden.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }

        public List<Pind> Pinds { get; set; }
    }
}
