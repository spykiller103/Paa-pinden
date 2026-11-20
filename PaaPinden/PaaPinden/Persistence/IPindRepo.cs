using PaaPinden.Models;
namespace PaaPinden.Persistence
{
    public interface IPindRepo
    {
        Task<IEnumerable<Pind>> GetAllPindsAsync();
        Task<Pind?> GetPindByIdAsync(int id);
        Task<Pind> CreatePindAsync(Pind pind);
        Task DeletePindAsync(int id);

    }
}
