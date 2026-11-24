using PaaPinden.Data;
namespace PaaPinden.Persistence
{
    public interface IUserRepo
    {
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByIdAsync(string id);
        Task CreateUserAsync(ApplicationUser user);
        Task DeleteUserAsync(ApplicationUser user);
    }
}
