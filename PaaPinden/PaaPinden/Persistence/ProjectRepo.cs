using Microsoft.EntityFrameworkCore;
using PaaPinden.Data;
using PaaPinden.Models;

namespace PaaPinden.Persistence
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly DbContextOptions<PaaPindenContext> _options;

        public ProjectRepo(DbContextOptions<PaaPindenContext> options)
        {
            _options = options;
        }

        public async Task<List<Project>> GetAllProjectsAsync()
        {
            PaaPindenContext? context = new PaaPindenContext(_options);

            return await context.Projects
                .Include(project => project.DiagramTool)
                .ToListAsync();
        }

        public async Task<List<Project>> GetProjectsByUserIdAsync(string userId)
        {
             PaaPindenContext? context = new PaaPindenContext(_options);

            return await context.Projects
                .Where(project => project.ApplicationUserId == userId)
                .Include(project => project.DiagramTool)
                .ToListAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
             PaaPindenContext? context = new PaaPindenContext(_options);

            return await context.Projects
                .Include(project => project.DiagramTool)
                .FirstOrDefaultAsync(project => project.Id == id);
        }

        public async Task CreateProjectAsync(Project project)
        {
            PaaPindenContext? context = new PaaPindenContext(_options);

            context.Projects.Add(project);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProjectAsync(Project project)
        {
            PaaPindenContext? context = new PaaPindenContext(_options);

            context.Projects.Remove(project);
            await context.SaveChangesAsync();
        }
    }
}
