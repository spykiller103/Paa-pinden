using PaaPinden.Models;

namespace PaaPinden.Persistence
{
    public class PindRepo : IPindRepo
    {
        private List<Pind> listOfPinds;

        public async Task CreatePindAsync(Pind pind)
        {
            throw new NotImplementedException();
        }
        public async Task DeletePindAsync(Pind pind)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pind>> GetAllPindsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Pind> GetPindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
