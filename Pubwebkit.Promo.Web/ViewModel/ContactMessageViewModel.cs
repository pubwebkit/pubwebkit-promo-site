using System.ComponentModel.DataAnnotations;

namespace Pubwebkit.Promo.Web.ViewModel
{
    public class ContactMessageViewModel
    {
        [Required(ErrorMessage = "Please specify your name.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email adress is required.")]
        [Display(Name = "Email adress")]
        [EmailAddress(ErrorMessage = "Specified email address is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message textbox can't be empty. ")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}