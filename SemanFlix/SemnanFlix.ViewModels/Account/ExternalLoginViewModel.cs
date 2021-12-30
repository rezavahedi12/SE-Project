using System.ComponentModel.DataAnnotations;

namespace SemnanFlix.ViewModels.Account
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
