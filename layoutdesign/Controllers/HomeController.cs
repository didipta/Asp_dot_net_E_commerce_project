using layoutdesign.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace layoutdesign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var userdata = new
            {
                Username = "JohnDoe",
                Email = "johndoe@gmail.com",
                Age = 25,
                address=new { Address = "123 Main St", City = "New York", State = "NY", Zip = "10001" }

            };
            var jsonString = JsonConvert.SerializeObject(userdata);
            HttpContext.Session.SetString("UserDATA", jsonString);
            var products = new List<ProductViewModel>
        {
            new ProductViewModel { Title = "Product 1", ImageUrl = "https://images.pexels.com/photos/4158/apple-iphone-smartphone-desk.jpg?cs=srgb&dl=pexels-pixabay-4158.jpg&fm=jpg", Price = 49.99m },
            new ProductViewModel { Title = "Product 2", ImageUrl = "https://via.placeholder.com/300x200", Price = 59.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m },
            new ProductViewModel { Title = "Product 3", ImageUrl = "https://via.placeholder.com/300x200", Price = 39.99m }
        };
            var chartData = new List<ChartData>
            {
                new ChartData { Label = "Category A", Value = 430 },
                new ChartData { Label = "Category B", Value = 450 },
                new ChartData { Label = "Category B", Value = 550 },
                new ChartData { Label = "Category B", Value = 750 },
                new ChartData { Label = "Category B", Value = 150 },
                new ChartData { Label = "Category B", Value = 250 },
                new ChartData { Label = "Category B", Value = 350 },
                new ChartData { Label = "Category B", Value = 450 },
                new ChartData { Label = "Category C", Value = 820 }
            };

            // Pass the data to the view as JSON
            ViewBag.ChartData = JsonConvert.SerializeObject(chartData);
            return View(products);
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
