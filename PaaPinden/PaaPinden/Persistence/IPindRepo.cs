using PaaPinden.Models;
namespace PaaPinden.Persistence
{
    public interface IPindRepo
    {
        Task<IEnumerable<Pind>> GetAllPindsAsync();
        Task<Pind> GetPindByIdAsync(int id);
        Task CreatePindAsync(Pind pind);
        Task DeletePindAsync(Pind pind);

    }
}
