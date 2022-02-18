 using System.Collections.Generic;
using System.Linq;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Mocks
{
    public class MockSneakers : ISneakers
    {
        private readonly ISneakersCategory _sneakersCategory = new MockCategory();
        
        public IEnumerable<Sneaker> Sneakers
        {
            get
            {
                return new List<Sneaker>
                {
                    new Sneaker
                    {
                        Name = "Nike Air2",
                        Season = "Лето",
                        Img = "/img/ar99.jpg",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = _sneakersCategory.AllCategories.First(),
                    },
                    new Sneaker
                    {
                        Name = "Nike Air221",
                        Season = "Лето",
                        Img = "/img/ar99207.jpg",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = _sneakersCategory.AllCategories.First(),
                    },new Sneaker
                    {
                        Name = "Nike Air221",
                        Season = "Лето",
                        Img = "/img/ar99327.jpg",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = _sneakersCategory.AllCategories.Last(),
                    },
                };
            }
        }

        public IEnumerable<Sneaker> GetFavSneakers { get; set; }
        public Sneaker GetObjectSneaker(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}