using PaaPinden.Models;
using PaaPinden.Persistence;
using PaaPinden.Data;

namespace PaaPinden.Service
{
    public class UserService
    {

        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            return await _userRepo.GetAllUsersAsync();
        }
        public async Task<ApplicationUser> GetUserByIdAsync(int id)
        {
            return await _userRepo.GetUserByIdAsync(id);
        }
        public async Task CreateUserAsync(ApplicationUser user)
        {
            await _userRepo.CreateUserAsync(user);
        }
        public async Task DeleteUserAsync(ApplicationUser user)
        {
            await _userRepo.DeleteUserAsync(user);
        }
    }
}
