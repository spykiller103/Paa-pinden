using PaaPinden.DTO;

namespace PaaPinden.Services
{
    public interface IPindService
    {
        Task CreatePindAsync(PindDTO dto);
        Task DeletePindAsync(int pindId);
    }
}
