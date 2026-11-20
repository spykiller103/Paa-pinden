using PaaPinden.Models;

namespace PaaPinden.Persistence
{
    public interface IRecipeRepo
    {
        Task<List<Recipe>> GetAllRecipesAsync();
        Task<Recipe> GetRecipeByIdAsync(int id);
        Task CreateRecipeAsync(Recipe recipe);
        Task DeleteRecipeAsync(Recipe recipe);
    }
}
