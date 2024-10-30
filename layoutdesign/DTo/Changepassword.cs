using System.ComponentModel.DataAnnotations;

namespace layoutdesign.DTo
{
    public class Changepassword
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("OldPassword", ErrorMessage = "Password not Match")]
        public string NewPassword { get; set; }
    }
}
