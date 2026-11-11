using Microsoft.AspNetCore.Identity;
namespace PaaPinden.Data;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string Username { get; set; }
    public byte[] ProfilePicture { get; set; }
    public string Biography { get; set; }
}
