using System.Collections.Generic;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Interfaces
{
    public interface ISneakers
    {
        IEnumerable<Sneaker> Sneakers { get; }
        IEnumerable<Sneaker> GetFavSneakers { get; }
        Sneaker GetObjectSneaker(int id);
    }
}