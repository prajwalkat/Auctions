using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface IBidService
    {
        Task Add(Bid bid);
    }
}
