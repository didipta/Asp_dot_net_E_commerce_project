using System.ComponentModel.DataAnnotations;

namespace layoutdesign.DTo
{
    public class Registerdto
    {
        [Required]
        [MinLength(3,ErrorMessage ="First Name must be at least 3 characters long"), MaxLength(50,ErrorMessage ="First Name must be at most 50 characters long")]
        [Display(Name = "First Name")]
        public string FisrtName { get; set; }

        [Required]
        [MinLength(3,ErrorMessage ="Last Name must be at least 3 characters long"), MaxLength(50,ErrorMessage ="Last Name must be at most 50 characters long")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

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

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password not Match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
