using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubwebkit.Promo.Infrastructure.Types
{
    public class Toastr
    {
        #region Properties

        public string Message { get; set; }
        public string Title { get; set; }
        public ToastrType Type { get; set; }

        #endregion
    }
}
