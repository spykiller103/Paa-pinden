using PaaPinden.Data;

namespace PaaPinden.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int DiagramToolId { get; set; }
        public DiagramTool? DiagramTool { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
