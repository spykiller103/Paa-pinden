namespace PaaPinden.Models
{
    public class DiagramTool
    {
        public string Name { get; set; }
        public List<int> Columns { get; set; }
        public List<int> Rows { get; set; }
        public bool ProtectetContent { get; set; }
        public int[,] Cells { get; set; }
        public bool UsedCells { get; set; }
    }
}
