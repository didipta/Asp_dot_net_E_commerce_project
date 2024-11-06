using layoutdesign.DTo.Category;
using layoutdesign.Models;

namespace layoutdesign.Mappers
{
    public static class Categorymapper
    {
        public static Showcategory Showcategory(this Category category)
        {
            return new Showcategory
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ImageUrl = category.ImageUrl
            };
        }

    }
}
