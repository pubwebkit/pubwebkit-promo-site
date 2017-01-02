using Mvc.Mailer;
using Pubwebkit.Promo.Web.ViewModel;

namespace Pubwebkit.Promo.Web.Mailers
{ 
    public interface IContactMailer
    {
        MvcMailMessage Contact(ContactMessageViewModel viewModel);
	}
}