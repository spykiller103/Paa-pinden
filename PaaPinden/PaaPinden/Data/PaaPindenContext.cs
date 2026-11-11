using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaaPinden.Models;

namespace PaaPinden.Data
{
    public class PaaPindenContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DiagramTool> DiagramTools { get; set; }
        public DbSet<Pind> Pinds { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }

        public PaaPindenContext(DbContextOptions<PaaPindenContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Comment>();
        }
    }
}
