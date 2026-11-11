using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaaPinden.Models;

namespace PaaPinden.Data
{
    public class PaaPindenContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DiagramTool> DiagramTools { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Pind> Pinds { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public PaaPindenContext(DbContextOptions<PaaPindenContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Pind>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Pind)
                .HasForeignKey(c => c.PindId)
                .IsRequired(false);

            builder.Entity<Recipe>()
                .HasMany(r => r.Comments)
                .WithOne(c => c.Recipe)
                .HasForeignKey(c => c.RecipeId)
                .IsRequired(false);

            builder.Entity<ApplicationUser>()
                .HasMany(a => a.Pinds)
                .WithOne(p => p.ApplicationUser)
                .HasForeignKey(p => p.ApplicationUserId)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .HasMany(a => a.Recipes)
                .WithOne(r => r.ApplicationUser)
                .HasForeignKey(r => r.ApplicationUserId)
                .IsRequired();

            builder.Entity<DiagramTool>()
                .HasMany(d => d.Projects)
                .WithOne(p => p.DiagramTool)
                .HasForeignKey(p => p.DiagramToolId)
                .IsRequired(false);

            builder.Entity<Project>()
                .HasOne(p => p.ApplicationUser)
                .WithMany(a => a.Projects)
                .HasForeignKey(p => p.ApplicationUserId)
                .IsRequired();

        }
    }
}
