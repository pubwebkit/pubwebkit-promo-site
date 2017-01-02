using System;
using System.Net.Mail;
using System.Web.Configuration;
using Mvc.Mailer;
using Pubwebkit.Promo.Web.ViewModel;

namespace Pubwebkit.Promo.Web.Mailers
{ 
    public class ContactMailer : MailerBase, IContactMailer 	
	{
		public ContactMailer()
		{
			MasterName="_Layout";
		}

        public virtual MvcMailMessage Contact(ContactMessageViewModel viewModel)
		{
            ViewData.Model = viewModel;
			return Populate(x =>
			{
                x.Subject = String.Format("Pubwebkit contact form. Message from {0}", viewModel.Email);
				x.ViewName = "ContactForm";
                x.To.Add(WebConfigurationManager.AppSettings["ContactEmail"]);
			});
		}
 	}
}