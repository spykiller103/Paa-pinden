namespace PaaPinden.Models
{
    public class Recipe : Pind
    {
        public string Title { get; set; }
        public TimeOnly TimeUsage { get; set; }
        public string Mask { get; set; }
        public double KnittingNeedleSize { get; set; }
    }
}
