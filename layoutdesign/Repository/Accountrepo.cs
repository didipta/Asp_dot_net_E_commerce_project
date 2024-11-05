using layoutdesign.DTo;
using layoutdesign.Interfaces;
using layoutdesign.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace layoutdesign.Repository
{
    public class Accountrepo : IAccount
    {
        private readonly SignInManager<Appuser> _signInManager;

        public Accountrepo(SignInManager<Appuser> signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task<bool> Login(Login login)
        {
            var user = await _signInManager.UserManager.FindByEmailAsync(login.Email);


            return true;


        }

        public Task<IActionResult> Register(Registerdto registerdto)
        {
            throw new NotImplementedException();
        }
    }
}
