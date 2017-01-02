using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Optimization;

namespace Pubwebkit.Promo.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var ie8Bundle = new ScriptBundle("~/Bundles/IE8");
            ie8Bundle.Include("~/scripts/twitter-bootstrap/assets/js/html5shiv.js",
                              "~/scripts/twitter-bootstrap/assets/js/respond.min.js");
            bundles.Add(ie8Bundle);

            var commonScriptsBundle = new ScriptBundle("~/Bundles/CommonScripts");
            commonScriptsBundle.Include("~/scripts/jquery-1.11.1.js",
                                        "~/content/twitter-bootstrap/dist/js/bootstrap.min.js",
                                        "~/scripts/app/bootstrapper.js",
                                        "~/scripts/lib/retina.js",
                                        "~/scripts/toastr.js");

            if (!HttpContext.Current.IsDebuggingEnabled)
            {
                commonScriptsBundle.Include("~/Scripts/ga.js");
            }

            bundles.Add(commonScriptsBundle);

            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                   .Include("~/scripts/jquery.unobtrusive*",
                            "~/scripts/jquery.validate*",
                            "~/scripts/bootstrap-validation.js"));

        }
    }
}