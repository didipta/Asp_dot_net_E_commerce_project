using layoutdesign.DTo;
using Microsoft.AspNetCore.Mvc;

namespace layoutdesign.Interfaces
{
    public interface IAccount
    {
        Task<IActionResult> Login(Login login);
        Task<IActionResult> Register(Registerdto registerdto);
    }
}
