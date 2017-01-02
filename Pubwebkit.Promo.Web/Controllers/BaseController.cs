using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pubwebkit.Promo.Data.Contracts;

namespace Pubwebkit.Promo.Web.Controllers
{
    public abstract class BaseController: Controller
    {
        public IPubwebkitUow Uow { get; set; }
    }
}