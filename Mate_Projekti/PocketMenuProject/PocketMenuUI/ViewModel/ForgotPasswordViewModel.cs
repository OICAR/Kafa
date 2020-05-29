using System.ComponentModel.DataAnnotations;

namespace PocketMenuUI.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}