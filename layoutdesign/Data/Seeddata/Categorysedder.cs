using layoutdesign.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace layoutdesign.Data.Seeddata
{
    public class Categorysedder
    {
        public static void SeedCategories(ModelBuilder builder)
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    slug = "electronics",
                    ImageUrl = "https://example.com/images/electronics.jpg",
                    Description = "Devices and gadgets including phones, laptops, and more."
                },
                new Category
                {
                    Id = 2,
                    Name = "Fashion",
                    slug = "fashion",
                    ImageUrl = "https://example.com/images/fashion.jpg",
                    Description = "Clothing, accessories, and fashion products."
                },
                new Category
                {
                    Id = 3,
                    Name = "Home Appliances",
                    slug = "home-appliances",
                    ImageUrl = "https://example.com/images/home_appliances.jpg",
                    Description = "Appliances for everyday household needs."
                },
                new Category
                {
                    Id = 4,
                    Name = "Books",
                    slug = "books",
                    ImageUrl = "https://example.com/images/books.jpg",
                    Description = "A variety of books and reading materials."
                }
            };

            builder.Entity<Category>().HasData(categories);
        }
    }
}
