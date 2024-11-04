using System.ComponentModel.DataAnnotations;

namespace layoutdesign.DTo
{
    public class Login
    {
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long"),
          MaxLength(50,
            ErrorMessage = "Password must be at most 50 characters long"
            ),
          RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$",
            ErrorMessage = "Password not strong enough."
            )
          ]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       
        [Display(Name ="Remember me")]

        public bool RememberMe { get; set; }
    }
}
