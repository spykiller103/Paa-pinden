using PaaPinden.Data;
using PaaPinden.Models;
using Microsoft.EntityFrameworkCore;

namespace PaaPinden.Persistence
{
    public class PindRepo : IPindRepo
    {
        //private List<Pind> listOfPinds;
        private readonly PaaPindenContext _context;

        public PindRepo(PaaPindenContext context)
        {
            _context = context;
        }

        public async Task<Pind> CreatePindAsync(Pind pind)
        {
            await _context.AddAsync(pind);
            await _context.SaveChangesAsync();

            return pind;
        }
        public async Task DeletePindAsync(int id)
        {
            var pind = await _context.Pinds
                .FindAsync(id);

            if (pind != null)
            {
                _context.Pinds.Remove(pind);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Pind>> GetAllPindsAsync()
        {
            return await _context.Pinds
                .Include(p => p.ApplicationUser)
                .Include(p => p.LikedBy)
                .Include(p => p.Comments)
                .ThenInclude(c => c.ApplicationUser)
                .OrderByDescending(p => p.PostDate)
                 .ToListAsync();
        }

        public async Task<Pind?> GetPindByIdAsync(int id)
        {
            return await _context.Pinds
                .Include (p => p.ApplicationUser)
                .Include(p => p.LikedBy)
                .Include(p => p.Comments)
                .ThenInclude(c => c.ApplicationUser)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task ToggleLikeAsync(int pindId, string userId)
        {
           var pind = await GetPindByIdAsync(pindId);
            if (pind == null) return;

            var existingLike = pind.LikedBy.FirstOrDefault(u => u.Id == userId);

            if (existingLike != null)
            {
                // The user has already liked it so remove the like
                pind.LikedBy.Remove(existingLike);
            }
            else
            {
                // The user hasnt liked it yet so add the like
                var user = await _context.Users.FindAsync(userId);
                if (user == null) return;

                pind.LikedBy.Add(user);
            }

            await _context.SaveChangesAsync();

        }


        public async Task AddCommentAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }
    }
}
