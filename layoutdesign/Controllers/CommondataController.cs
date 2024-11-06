using layoutdesign.DTo.Brand;
using layoutdesign.DTo.Category;
using layoutdesign.DTo;
using layoutdesign.Models;
using layoutdesign.Repository;
using Microsoft.AspNetCore.Mvc;
using layoutdesign.Mappers;

namespace layoutdesign.Controllers
{
    public class CommondataController : Controller
    {
        private readonly Categoryrepo _categoryrepo;
        private readonly Brandrepo _brandrepo;

        public CommondataController(Categoryrepo categoryrepo, Brandrepo brandrepo)
        {
            _categoryrepo = categoryrepo;
            _brandrepo = brandrepo;
        }
        public async Task<IActionResult> GetHeaderData()
        {
            // Fetch categories and brands
            List<Category> categories = await _categoryrepo.GetCategories();
            List<Showcategory> showcategory = categories.Select(s => s.Showcategory()).ToList();

            List<Brand> brands = await _brandrepo.GetBrands();
            List<Showbrand> showbrand = brands.Select(s => s.Showbrand()).ToList();

            // Create an object to pass back as JSON
            var headerData = new
            {
                Showcategory = showcategory,
                Showbrand = showbrand
            };

            return Json(headerData);  // Returns the object as JSON
        }
    }
}
