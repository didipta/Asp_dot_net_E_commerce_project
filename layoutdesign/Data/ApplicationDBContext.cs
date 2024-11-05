using layoutdesign.Data.Seeddata;
using layoutdesign.Models;
using layoutdesign.Models.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace layoutdesign.Data
{
    public class ApplicationDBContext : IdentityDbContext<Appuser>
    {
        public DbSet<Log> Logs { get; set; }
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ProductConfiguration.Configure(builder);
            CartConfiguration.Configure(builder);
            RoleSeeder.SeedRoles(builder);
            Categorysedder.SeedCategories(builder);
            Brandseeder.SeedBrands(builder);

        }
    }
}
