using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubwebkit.Promo.Model
{
    public class Subscriber
    {
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
