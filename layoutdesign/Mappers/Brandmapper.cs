using layoutdesign.DTo.Brand;
using layoutdesign.Models;

namespace layoutdesign.Mappers
{
    public static class Brandmapper
    {
        public static Showbrand Showbrand(this Brand brand)
        {
            return new Showbrand
            {
                Id = brand.Id,
                Name = brand.Name,
                slug = brand.slug,
                Description = brand.Description,
                ImageUrl = brand.ImageUrl
            };
        }
    }
}
