using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using Xunit;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Max length is {25}")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Min length is {2} and Max Length is {25}")]
        [Range(2, 25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Age range between (1-120)")]
        public int Age { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "12/31/2018", ErrorMessage = "Date range between 1/1/1900 - 12/31/2018")]
        public DateTime Birthday { get; set; }

        [Required]
        [EmailAddress (ErrorMessage ="Not a valid email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Emails don't match")]
        [Display(Name = "Confirm Email")]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Url]
        [MinLength(7, ErrorMessage = "Minimum length is 7")]
        public string Website { get; set; }

        [Editable(false)]
        public string School { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        [Required]
        [PasswordPropertyText]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
