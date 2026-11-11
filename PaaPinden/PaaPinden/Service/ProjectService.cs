using PaaPinden.Models;
using PaaPinden.Persistence;

namespace PaaPinden.Service
{
    public class ProjectService
    {
        private readonly IProjectRepo _projectRepo;
       
        public ProjectService(IProjectRepo projectRepo)
        {
            _projectRepo = projectRepo;
        }
        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return await _projectRepo.GetAllProjectsAsync();
        }
        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectRepo.GetProjectByIdAsync(id);
        }
        public async Task CreateProjectAsync(Project project)
        {
            await _projectRepo.CreateProjectAsync(project);
        }
        public async Task DeleteProjectAsync(Project project)
        {
            await _projectRepo.DeleteProjectAsync(project);
        }

    }
}
