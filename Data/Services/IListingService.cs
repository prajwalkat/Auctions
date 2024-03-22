using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);

        Task<Listing> GetById(int? id);

    }
}
