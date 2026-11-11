namespace PaaPinden.Models
{
    public class DiagramTool
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int LockedCells { get; set; }
        public int Cells { get; set; }
        public int UsedCells { get; set; }

        public List<Project> Projects { get; set; } = new();
    }
}
