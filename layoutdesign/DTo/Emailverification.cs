using System.ComponentModel.DataAnnotations;

namespace layoutdesign.DTo
{
    public class Emailverification
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
