namespace PaaPinden.Services
{
    public class FileUploadService : IFileUploadService
    {
        public async Task<string> SaveFileAsync(IFormFile file)
        {
            var fileName = Path.GetFileName(file.FileName);
            var folderPath = Path.Combine("C:\\Pind-Files");
            var filePath = Path.Combine(folderPath, fileName);


            Directory.CreateDirectory(folderPath);
            await using var stream = new FileStream(filePath, FileMode.Create);


            await file.CopyToAsync(stream);

            return $"/pind-files/{Uri.EscapeDataString(fileName)}";
        }
    }
}
