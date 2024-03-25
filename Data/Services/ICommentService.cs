using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface ICommentService
    {
        Task Add(Comment comment);

    }
}
