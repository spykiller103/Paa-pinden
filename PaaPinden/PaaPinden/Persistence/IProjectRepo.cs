using PaaPinden.Models;
namespace PaaPinden.Persistence
{
    public interface IProjectRepo
    {
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(int id);
        Task CreateProjectAsync(Project project);
        Task DeleteProjectAsync(Project project);
    }
}
