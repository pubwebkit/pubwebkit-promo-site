using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Pubwebkit.Promo.Infrastructure.Types;

namespace Pubwebkit.Promo.Infrastructure.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString Toastr(this HtmlHelper htmlHelper)
        {
            var script = new TagBuilder("script");
            var toastr = htmlHelper.ViewContext.TempData["_toastr"] as Toastr;
            var result = MvcHtmlString.Empty;

            if (toastr != null)
            {
                var scriptBody = String.Empty;

                switch (toastr.Type)
                {
                    case ToastrType.Error:
                        scriptBody = String.Format("toastr.error('{0}', '{1}');", toastr.Message, toastr.Title);
                        break;

                    case ToastrType.Info:
                        scriptBody = String.Format("toastr.info('{0}', '{1}');", toastr.Message, toastr.Title);
                        break;

                    case ToastrType.Success:
                        scriptBody = String.Format("toastr.success('{0}', '{1}');", toastr.Message, toastr.Title);
                        break;

                    case ToastrType.Warning:
                        scriptBody = String.Format("toastr.warning('{0}', '{1}');", toastr.Message, toastr.Title);
                        break;
                }

                script.InnerHtml = String.Format("$(function () {{ {0} }})", scriptBody);
                result = MvcHtmlString.Create(script.ToString());
                htmlHelper.ViewContext.TempData.Remove("_toastr");
            }

            return result;
        }
    }
}
