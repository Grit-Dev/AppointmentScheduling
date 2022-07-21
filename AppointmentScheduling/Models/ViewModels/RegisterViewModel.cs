using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduling.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The Password must be minium of 6 characters" , MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password does not match. Please Try Again")]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Role Name")]

        public string RoleName { get; set; }


    }
}
