namespace PaaPinden.Models
{
    public class Post
    {
        public byte[] MediaType { get; set; }
        public string Category { get; set; }
        public DateTime PostDate { get; set; }
        public int Like { get; set; }
        public string Comment { get; set; }

    }
}
