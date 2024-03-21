using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();

    }
}
