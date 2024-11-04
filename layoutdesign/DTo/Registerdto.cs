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
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [Range(11, 11, ErrorMessage = "Phone Number must be 11 digits")]
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
