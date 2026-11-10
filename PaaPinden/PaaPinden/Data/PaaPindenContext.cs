using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PaaPinden.Data
{
    public class PaaPindenContext : IdentityDbContext<ApplicationUser>
    {
        public PaaPindenContext(DbContextOptions<PaaPindenContext> options) : base(options)
        {

        }
    }
}
