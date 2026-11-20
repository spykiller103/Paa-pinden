using PaaPinden.DTO;
using PaaPinden.Models;
using PaaPinden.Persistence;

namespace PaaPinden.Services
{
    public class PindService : IPindService
    {
        private readonly ICurrentUserService _currentUser;
        private readonly IFileUploadService _fileUpload;
        private readonly IPindRepo _pindRepo;

        public PindService(ICurrentUserService currentUser, IFileUploadService fileUpload, IPindRepo pindRepo)
        {
            _currentUser = currentUser;
            _fileUpload = fileUpload;
            _pindRepo = pindRepo;
        }


        public async Task CreatePindAsync(PindDTO dto)
        {
            var userId = await _currentUser.GetUserIdAsync()
                 ?? throw new UnauthorizedAccessException("Du skal være logget ind.");

            var mediaPath = await _fileUpload.SaveFileAsync(dto.MediaType);

            Pind pind = new Pind
            {
                MediaPath = mediaPath,
                Description = dto.Description,
                PostDate = DateTime.Now,
                ApplicationUserId = userId
            };
            await _pindRepo.CreatePindAsync(pind);
        }

        public async Task DeletePindAsync(int pindId)
        {
            var userId = await _currentUser.GetUserIdAsync()
                ?? throw new UnauthorizedAccessException("Du skal være logget ind.");

            var pind = await _pindRepo.GetPindByIdAsync(pindId);

            if(pind.ApplicationUserId != userId)
            {
                throw new UnauthorizedAccessException("Du kan kun slette dine egne opslag.");

            }
            await _pindRepo.DeletePindAsync(pindId);
        }
    }
}
