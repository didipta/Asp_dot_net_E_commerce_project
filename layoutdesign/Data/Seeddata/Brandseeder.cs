using layoutdesign.Models;
using Microsoft.EntityFrameworkCore;

namespace layoutdesign.Data.Seeddata
{
    public class Brandseeder
    {
        public static void SeedBrands(ModelBuilder builder)
        {
            List<Brand> brands = new List<Brand>
            {
                new Brand {
                    Id = 1,
                    Name = "Apple",
                    slug = "apple",
                    ImageUrl = "https://www.apple.com/ac/structured-data/images/knowledge_graph_logo.png?201810271738",
                    Description = "Apple Inc. is an American multinational technology company that specializes in consumer electronics, computer software, and online services. Apple is the world's largest technology company by revenue and, since January 2021, the world's most valuable company.",
                },
               new Brand
               {
                 Id = 2,
                 Name = "Samsung",
                 slug = "samsung",
                 ImageUrl = "https://www.samsung.com/etc/designs/smg/global/imgs/logo-square-letter.png",
                 Description = "Samsung Electronics Co., Ltd. is a South Korean multinational electronics company headquartered in the Yeongtong District of Suwon. It is the pinnacle of the Samsung chaebol, accounting for 70% of the group's revenue in 2012.",

               },
              

            };
            builder.Entity<Brand>().HasData(brands);

        }
    }
}
