using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pubwebkit.Promo.Infrastructure.Extensions;
using Pubwebkit.Promo.Infrastructure.Types;
using Pubwebkit.Promo.Web.Mailers;
using Pubwebkit.Promo.Web.ViewModel;

namespace Pubwebkit.Promo.Web.Controllers
{
    public class ContactController : Controller
    {
        #region Private members

        private IContactMailer _contactMailer = new ContactMailer();

        #endregion

        #region Props

        public IContactMailer ContactMailer
        {
            get { return _contactMailer; }
            set { _contactMailer = value; }
        }

        #endregion

        #region Actions

        public ActionResult Index()
        {
            return View(new ContactMessageViewModel());
        }

        public ActionResult SendMessage(ContactMessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                ContactMailer.Contact(model).SendAsync();
                this.Toastr("Email has been sent", ToastrType.Info, "Thank you!");
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", model);
            }
        }

        #endregion
    }
}
