
using Microsoft.EntityFrameworkCore;
using layoutdesign.Models;

namespace layoutdesign.Models.Configurations
{
    public static class CartConfiguration
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Cart>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.HasOne(c => c.User)
                      .WithOne()
                      .HasForeignKey<Cart>(c => c.UserId)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(c => c.Items)
                      .WithOne(i => i.Cart)
                      .HasForeignKey(i => i.CartId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<CartItem>(entity =>
            {
                entity.HasKey(ci => ci.Id);
                entity.HasOne(ci => ci.Product)
                      .WithMany()
                      .HasForeignKey(ci => ci.ProductId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
