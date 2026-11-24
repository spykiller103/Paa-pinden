using Microsoft.AspNetCore.Identity;
using PaaPinden.Models;
namespace PaaPinden.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public string ProfilePicture { get; set; } = "/Content/Images/default-profile-picture.png";
    public string? Biography { get; set; }

    public List<Project> Projects { get; set; } = new();
    public List<Pind> Pinds { get; set; } = new();
    public List<Recipe> Recipes { get; set; } = new();
}
