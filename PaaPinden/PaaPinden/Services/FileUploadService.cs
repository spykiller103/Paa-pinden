namespace PaaPinden.Services
{
    public class FileUploadService : IFileUploadService
    {
        public async Task<string> SaveFileAsync(IFormFile file)
        {

            var folderPath = Path.Combine("C:\\Pind-Files");
            var filePath = Path.Combine(folderPath, file.FileName);


            Directory.CreateDirectory(folderPath);
            await using var stream = new FileStream(filePath, FileMode.Create);


            await file.CopyToAsync(stream);

            return filePath;
        }
    }
}
