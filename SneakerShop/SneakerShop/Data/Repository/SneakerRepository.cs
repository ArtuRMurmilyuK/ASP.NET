using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Repository
{
    public class SneakerRepository : ISneakers
    {
        private readonly AppDBContent _appDbContent;

        public SneakerRepository(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Sneaker> Sneakers => _appDbContent.Sneakers.Include(s => s.Category);

        public IEnumerable<Sneaker> GetFavSneakers =>
            _appDbContent.Sneakers.Where(s => s.IsFavorite).Include(c => c.Category);

        public Sneaker GetObjectSneaker(int id) => _appDbContent.Sneakers.FirstOrDefault(p => p.Id == id);
    }
}