using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using layoutdesign.Models;

namespace layoutdesign.Models.Configurations
{
    public static class ProductConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Product>(entity =>
            {
                entity.HasOne<Category>(p => p.Category)
                      .WithMany(c => c.Products)
                      .HasForeignKey(p => p.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne<Brand>(p => p.Brand)
                      .WithMany(b => b.Products)
                      .HasForeignKey(p => p.BrandId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}

