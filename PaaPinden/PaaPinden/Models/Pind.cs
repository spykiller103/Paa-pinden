using PaaPinden.Data;
using System.ComponentModel.DataAnnotations;


namespace PaaPinden.Models
{
    public class Pind
    {

        public int Id { get; set; }
       
        public string MediaPath { get; set; } = string.Empty;
        
        public string? Description {  get; set; }

        public DateTime PostDate { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public List<Comment> Comments { get; set; } = new();
     
        public ICollection<ApplicationUser> LikedBy { get; set; } = new List<ApplicationUser>();
    }
}