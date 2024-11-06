using layoutdesign.DTo;
using layoutdesign.DTo.Brand;
using layoutdesign.DTo.Category;
using layoutdesign.Mappers;
using layoutdesign.Models;
using layoutdesign.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace layoutdesign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Categoryrepo _categoryrepo;
        private readonly Brandrepo _brandrepo;

        public HomeController(ILogger<HomeController> logger, Categoryrepo categoryrepo,Brandrepo brandrepo)
        {
            _logger = logger;
            _categoryrepo = categoryrepo;
            _brandrepo = brandrepo;
        }
        
        public async Task<IActionResult> Index()
        {
            
            
            List<Category> categories = await _categoryrepo.GetCategories();
            List<Showcategory> showcategory = categories.Select(s => s.Showcategory()).ToList();

            List<Brand> brands = await _brandrepo.GetBrands();
            List<Showbrand> showbrand = brands.Select(s => s.Showbrand()).ToList();

            var homedatashow = new Homedatashow
            {
                Showcategory = showcategory,
                Showbrand = showbrand

            };

            return View(homedatashow);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
