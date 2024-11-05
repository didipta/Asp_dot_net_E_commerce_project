using layoutdesign.DTo;
using layoutdesign.Mappers;
using layoutdesign.Models;
using layoutdesign.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace layoutdesign.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Appuser> _signInManager;
        private readonly LoggingService _loggingService;

        public AccountController(SignInManager<Appuser> signInManager,LoggingService loggingService)
        {
            _signInManager = signInManager;
            _loggingService = loggingService;
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
            try
            {
                var user = await _signInManager.UserManager.FindByEmailAsync(login.Email);
                if (user == null)
                {
                    await _loggingService.LogError("Invalid login attempt", new Exception(
                        $"Email not found: {login.Email}"
                        ), login?.Email);

                    TempData["error"] = "Invalid login attempt. Email not found.";
                    return View(login);
                }
                var result = await _signInManager.PasswordSignInAsync(user.UserName, login.Password, login.RememberMe, false);

                if (!result.Succeeded)
                {
                    await _loggingService.LogError("Invalid login attempt", new Exception(
                        $"Invalid password for {login.Email}"
                        ), login?.Email);
                    TempData["error"] = "Invalid login attempt.";
                    return View(login);
                }
                await _loggingService.LogInfo("User logged in",user.Id);
            }
            catch (System.Exception ex)
            {
                await _loggingService.LogError("Error logging in", ex,login.Email);
                TempData["error"] = "An error occurred. Please try again.";
                return View(login);
            }

            return RedirectToAction("Index", "Home");

        }

        public async Task<ActionResult> Logout()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);

            try
            {
                await _loggingService.LogInfo("User logged out",userid!);
                await _signInManager.SignOutAsync();
            }
            catch
            {
                await _loggingService.LogError("Error logging out", new Exception("Error logging out"), userid!);

            }
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
                       await _loggingService.LogInfo("User registered", JsonConvert.SerializeObject(user));
                        TempData["success"] = "User created successfully";
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }
                }
               await _loggingService.LogError("Error creating user",new Exception(JsonConvert.SerializeObject(result.Errors)));
                foreach (var error in result.Errors)
                {

                    TempData["error"] = error.Description;
                    
                }
            }
            return View(registerdto);




        }

    
    }
}
