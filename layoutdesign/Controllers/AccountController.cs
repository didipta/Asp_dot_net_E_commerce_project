using Microsoft.AspNetCore.Mvc;

namespace layoutdesign.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
