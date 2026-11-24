using PaaPinden.DTO;
using PaaPinden.Models;
namespace PaaPinden.Services
{
    public interface IPindService
    {
        Task CreatePindAsync(PindDTO dto);
        Task DeletePindAsync(int pindId);
        Task<Pind?> GetPindByIdAsync(int pindId);
        Task ToggleLikeAsync(int pindId);
        Task AddCommentAsync(int pindId, string text);
    }
}
