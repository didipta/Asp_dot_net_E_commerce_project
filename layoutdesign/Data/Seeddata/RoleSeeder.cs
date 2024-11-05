// Data/RoleSeeder.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace layoutdesign.Data.Seeddata
{
    public static class RoleSeeder
    {
        public static void SeedRoles(ModelBuilder builder)
        {
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" },
                new IdentityRole { Name = "Employe", NormalizedName = "EMPLOYE" },
                new IdentityRole { Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                new IdentityRole { Name = "deliveryMan", NormalizedName = "DELIVERYMAN" }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
