using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace layoutdesign.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApiService _apiService;

        public ProductController(ApiService apiService) {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var apiUrl = "https://jsonplaceholder.typicode.com/posts"; // Replace with the actual API URL

            try
            {
                var products = await _apiService.GetApiResponseAsync<List<dynamic>>(apiUrl);
                return View(products);
            }
            catch (HttpRequestException ex)
            {
                ViewBag.ErrorMessage = "Error calling API: " + ex.Message;
                return View("Error");
            }

        }
    }
}
