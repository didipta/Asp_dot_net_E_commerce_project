using layoutdesign.DTo;
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

        public HomeController(ILogger<HomeController> logger, Categoryrepo categoryrepo)
        {
            _logger = logger;
            _categoryrepo = categoryrepo;
        }
        
        public async Task<IActionResult> Index()
        {
            
            
            List<Category> categories = await _categoryrepo.GetCategories();
            List<Showcategory> showcategory = categories.Select(s => s.Showcategory()).ToList();

            var homedatashow = new Homedatashow
            {
                Showcategory = showcategory,

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
