using System.ComponentModel.DataAnnotations;

namespace login_reg.Models
{
    public class LoginUser
    {   
        [Required(ErrorMessage = "Please enter your email.")]
        [Display(Name = "Email: ")]
        public string LogEmail { get; set; }
        
        [Required(ErrorMessage = "You must enter a password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string LogPassword { get; set; }
    }
}