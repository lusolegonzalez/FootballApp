using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Football.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Football.Data
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, IdentityUserClaim<int>,
        ApplicationUserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DbSet<Match> Matches { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
