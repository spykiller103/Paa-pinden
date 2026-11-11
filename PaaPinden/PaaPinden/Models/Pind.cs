namespace PaaPinden.Models
{
    public class Pind
    {
        public byte[] MediaType { get; set; }
        public string Category { get; set; }
        public DateTime PostDate { get; set; }
        public int Like { get; set; }
        public Comment Comment { get; set; }
    }
}
