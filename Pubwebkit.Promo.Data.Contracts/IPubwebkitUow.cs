using Pubwebkit.Promo.Model;

namespace Pubwebkit.Promo.Data.Contracts
{
    public interface IPubwebkitUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        ISubscriberRepository Subscribers { get; }
    }
}