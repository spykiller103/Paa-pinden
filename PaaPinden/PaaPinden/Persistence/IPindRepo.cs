using PaaPinden.Models;
namespace PaaPinden.Persistence
{
    public interface IPindRepo
    {
        Task<List<Pind>> GetAllPindsAsync();
        Task<Pind> GetPindByIdAsync(int id);
        Task CreatePindAsync(Pind pind);
        Task DeletePindAsync(Pind pind);

    }
}
