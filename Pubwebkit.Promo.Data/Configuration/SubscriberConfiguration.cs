using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pubwebkit.Promo.Model;

namespace Pubwebkit.Promo.Data.Configuration
{
    public class SubscriberConfiguration : EntityTypeConfiguration<Subscriber>
    {
        public SubscriberConfiguration()
        {
            HasKey(x => new {x.Id, x.Email});
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
