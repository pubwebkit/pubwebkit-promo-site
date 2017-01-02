using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Pubwebkit.Promo.Infrastructure.Types;

namespace Pubwebkit.Promo.Infrastructure.Extensions
{
    public static class ControllerExtensions
    {
        public static void Toastr(this Controller controller, string message, ToastrType type, string title = null)
        {
            controller.TempData["_toastr"] = new Toastr { Message = message, Title = title, Type = type };
        }
    }
}
