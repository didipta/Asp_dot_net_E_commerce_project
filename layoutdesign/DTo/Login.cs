using System.ComponentModel.DataAnnotations;

namespace layoutdesign.DTo
{
    public class Login
    {
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        //[MinLength(8),
        //  MaxLength(50),
        //  RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$",
        //  ErrorMessage = "Password must be 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       
        [Display(Name ="Remember me")]

        public bool RememberMe { get; set; }
    }
}
