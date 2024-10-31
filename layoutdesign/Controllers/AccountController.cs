using layoutdesign.DTo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace layoutdesign.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
             if(!ModelState.IsValid)
                return View(login);

            if (login.Email == "admin@gmail.com" && login.Password == "admin")
            {
                var userdata = new
                {
                    Username = login.Email,
                    Email = login.Email,
                    

                };
                var jsonString = JsonConvert.SerializeObject(userdata);
                HttpContext.Session.SetString("UserDATA", jsonString);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                TempData["error"] = "Invalid username or password";

                return View(login);
            }
        }
    }
}
