using layoutdesign.Models;
using layoutdesign.Repository;
using Microsoft.AspNetCore.Mvc;

namespace layoutdesign.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Categoryrepo _categoryrepo;

        public CategoryController(Categoryrepo categoryrepo)
        {
            _categoryrepo = categoryrepo;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _categoryrepo.AllCategories();
            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryIsactive(Int64 id)
        {
            var result = await _categoryrepo.CategoryIsactive(id);
            if (result != null)
            {
                TempData["success"] = "Category Update";
            }
            else
            {
                TempData["error"] = "Category Not Deleted";
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Create(Int64 id)
        {
            Category category = await _categoryrepo.GetCategoryById(id);
            return View(category);
        }





    }
}
