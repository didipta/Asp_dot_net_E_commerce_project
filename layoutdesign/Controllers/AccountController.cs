using layoutdesign.DTo;
using layoutdesign.Mappers;
using layoutdesign.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace layoutdesign.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Appuser> _signInManager;

        public AccountController(SignInManager<Appuser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(Login login)
        {
             if(!ModelState.IsValid)
                return View(login);
            var user = await _signInManager.UserManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                TempData["error"] = "Invalid login attempt. Email not found.";
                return View(login);
            }
            var result = await _signInManager.PasswordSignInAsync(user.UserName, login.Password, login.RememberMe, false);

            if (!result.Succeeded)
            {

                TempData["error"]="Invalid login attempt.";
                return View(login);
            }

             

            
            return RedirectToAction("Index", "Home");

        }

        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register( Registerdto registerdto)
        {
            if (!ModelState.IsValid)
                return View(registerdto);

            var user = registerdto.ToRegistation();
            if (user != null) {
                var result = await _signInManager.UserManager.CreateAsync(user, registerdto.Password);

                if (result.Succeeded)
                {
                    var roleResult = await _signInManager.UserManager.AddToRoleAsync(user, "User");

                    if (roleResult.Succeeded)
                    {
                        TempData["success"] = "User created successfully";
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }
                }
                foreach (var error in result.Errors)
                {
                    TempData["error"] = error.Description;
                    
                }
            }
            return View(registerdto);




        }

    
    }
}
