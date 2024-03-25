using Auctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data.Services
{
    public class BidService : IBidService
    {

        private readonly ApplicationDbContext _context;

        public BidService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
             await _context.SaveChangesAsync();
        }

        public IQueryable<Bid> GetAll()
        {
            //var applicationDbContext = _context.Bids.Include(l => l.User);
            var applicationDbContext = from a in _context.Bids.Include(l => l.Listing) select a;

            return applicationDbContext;
        }
    }
}
