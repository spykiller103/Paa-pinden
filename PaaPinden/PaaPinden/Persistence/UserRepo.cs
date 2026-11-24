using Microsoft.EntityFrameworkCore;
using PaaPinden.Data;
namespace PaaPinden.Persistence
{
    public class UserRepo : IUserRepo
    {
        private readonly DbContextOptions<PaaPindenContext> _options;
        private List<ApplicationUser> listOfUsers;

        public UserRepo(DbContextOptions<PaaPindenContext> options)
        {
            _options = options;
        }
        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            PaaPindenContext context = new PaaPindenContext(_options);

            return await context.Users.FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task CreateUserAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserAsync (ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
