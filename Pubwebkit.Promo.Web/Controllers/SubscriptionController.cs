using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pubwebkit.Promo.Data.Configuration;
using Pubwebkit.Promo.Data.Contracts;
using Pubwebkit.Promo.Infrastructure.Extensions;
using Pubwebkit.Promo.Infrastructure.Types;
using Pubwebkit.Promo.Model;
using Pubwebkit.Promo.Web.ViewModel;

namespace Pubwebkit.Promo.Web.Controllers
{
    public class SubscriptionController : BaseController
    {
        #region ctro
        public SubscriptionController(IPubwebkitUow uow)
        {
            Uow = uow;
        }
        #endregion

        #region Actions

        [HttpPost]
        public ActionResult Subscribe(SubscriptionViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (Uow.Subscribers.GetByEmail(model.Email).Any())
                {
                    this.Toastr("Your email address already in the the newsletter list", ToastrType.Warning, "Welcome back!");
                }
                else
                {
                    Uow.Subscribers.Add(new Subscriber { Email = model.Email });
                    Uow.Commit();
                    this.Toastr("Your email address has been added to the newsletter list", ToastrType.Info, "Thank you!");
                }
            }
            else
            {
                this.Toastr("Passed invalid email address", ToastrType.Error, "Oh snap!");
            }
            return Redirect(Request.UrlReferrer.ToString());
        }

        #endregion
    }
}
