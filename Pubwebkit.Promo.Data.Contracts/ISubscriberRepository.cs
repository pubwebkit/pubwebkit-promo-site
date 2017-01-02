using System.Linq;
using Pubwebkit.Promo.Model;

namespace Pubwebkit.Promo.Data.Contracts
{
    public interface ISubscriberRepository : IRepository<Subscriber>
    {
        IQueryable<Subscriber> GetByEmail(string email);
    }
}