using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace PaaPinden.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        //This service Authenticate the UserId of the CurrentUser
        //All other classes can just call this service instead of checking the id themself
        private readonly AuthenticationStateProvider _authStateProvider;

        public CurrentUserService(AuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
        }

        public async Task<string?> GetUserIdAsync()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            return authState.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
