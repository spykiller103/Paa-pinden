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
                .OrderByDescending(p => p.PostDate)
                 .ToListAsync();
        }

        public async Task<Pind?> GetPindByIdAsync(int id)
        {
            return await _context.Pinds
                .Include (p => p.ApplicationUser)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
