namespace PaaPinden.Services
{
    public interface IFileUploadService
    {
        Task<string> SaveFileAsync(IFormFile file);

    }
}
