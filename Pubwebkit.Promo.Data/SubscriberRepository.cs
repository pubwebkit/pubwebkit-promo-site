using System;
using System.Data.Entity;
using System.Linq;
using Pubwebkit.Promo.Data.Contracts;
using Pubwebkit.Promo.Model;

namespace Pubwebkit.Promo.Data
{
    public class SubscriberRepository : EFRepository<Subscriber>, ISubscriberRepository
    {
        public SubscriberRepository(DbContext dbContext) : base(dbContext) { }

        public IQueryable<Subscriber> GetByEmail(string email)
        {
            return DbSet.Where(x => x.Email.Equals(email));
        }
    }
}
