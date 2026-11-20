namespace PaaPinden.Services
{
    public interface ICurrentUserService
    {
        
            Task<string?> GetUserIdAsync();
        
    }
}
