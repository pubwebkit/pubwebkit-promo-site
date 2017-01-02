using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pubwebkit.Promo.Data.Configuration;
using Pubwebkit.Promo.Model;

namespace Pubwebkit.Promo.Data
{
    public class PubwebkitDbContext: DbContext
    {
        public PubwebkitDbContext()
            : base(nameOrConnectionString: "Pubwebkit") {}

        public DbSet<Subscriber> Subscribers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configurations
            modelBuilder.Configurations.Add(new SubscriberConfiguration());
        }
    }
}
