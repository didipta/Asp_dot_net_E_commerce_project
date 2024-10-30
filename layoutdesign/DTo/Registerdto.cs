using System.ComponentModel.DataAnnotations;

namespace layoutdesign.DTo
{
    public class Registerdto
    {
        [Required]
        [MinLength(3), MaxLength(50)]
        [Display(Name = "First Name")]
        public string FisrtName { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password not Match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
