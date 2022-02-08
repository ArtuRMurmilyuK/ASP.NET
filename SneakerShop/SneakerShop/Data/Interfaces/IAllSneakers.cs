using System.Collections.Generic;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Interfaces
{
    public interface IAllSneakers
    {
        IEnumerable<Sneaker> Sneakers { get; }
        IEnumerable<Sneaker> GetFavSneakers { get; set; }
        Sneaker GetObjectSneaker(int id);
    }
}