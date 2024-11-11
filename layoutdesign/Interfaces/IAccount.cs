using layoutdesign.DTo;
using layoutdesign.Models;
using Microsoft.AspNetCore.Mvc;

namespace layoutdesign.Interfaces
{
    public interface IAccount
    {
        Task SendEmailConfirmationAsync(Appuser user, string token);
    }
}
