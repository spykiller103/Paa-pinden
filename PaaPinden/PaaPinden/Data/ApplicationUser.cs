using Microsoft.AspNetCore.Identity;
using PaaPinden.Models;
namespace PaaPinden.Data;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public byte[] ProfilePicture { get; set; }
    public string Biography { get; set; }

    public List<Project> Projects { get; set; } = new();
    public List<Pind> Pinds { get; set; } = new();
    public List<Recipe> Recipes { get; set; } = new();
}
