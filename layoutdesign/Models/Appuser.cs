

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace layoutdesign.Models
{
    public class Appuser : IdentityUser
    {
        [Required]
        public string FisrtName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
