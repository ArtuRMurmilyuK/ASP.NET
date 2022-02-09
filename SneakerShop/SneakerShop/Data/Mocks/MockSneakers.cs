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
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstrongler.com.ua%2Fimage%2Fcache%2Fcatalog%2FProduct-2%2FMonarch2-1000x1000.png&imgrefurl=https%3A%2F%2Fstrongler.com.ua%2Fproduct%2Fmuzhskie-krossovki-nike-air-monarch-iv-415445-102%2F&tbnid=nQzMk1aXcSl3IM&vet=12ahUKEwjEpuSD7u_1AhWaP-wKHaTiAGMQMygfegUIARD5AQ..i&docid=_WzR2m39r3LvOM&w=1000&h=1000&q=nike&hl=ru&client=opera&ved=2ahUKEwjEpuSD7u_1AhWaP-wKHaTiAGMQMygfegUIARD5AQ",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = _sneakersCategory.AllCategories.First(),
                    },
                    new Sneaker
                    {
                        Name = "Nike Air221",
                        Season = "Лето",
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn-images.farfetch-contents.com%2F16%2F94%2F41%2F78%2F16944178_34127474_300.jpg&imgrefurl=https%3A%2F%2Fwww.farfetch.com%2Fru%2Fsets%2Fmen%2Fnike-dunk-trainers.aspx&tbnid=4FIx0lwkZ8nrbM&vet=12ahUKEwjEpuSD7u_1AhWaP-wKHaTiAGMQMygcegUIARDzAQ..i&docid=3l9roZZgYedDeM&w=300&h=400&q=nike&hl=ru&client=opera&ved=2ahUKEwjEpuSD7u_1AhWaP-wKHaTiAGMQMygcegUIARDzAQ",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = _sneakersCategory.AllCategories.First(),
                    },new Sneaker
                    {
                        Name = "Nike Air221",
                        Season = "Лето",
                        Img = "https://www.google.com/imgres?imgurl=http%3A%2F%2Fnewbalance.ru%2Fupload%2Fiblock%2Fce2%2Fmr530sg_nb_02_i.jpg&imgrefurl=https%3A%2F%2Fnewbalance.ru%2Fcatalog%2Fmen%2Fman_shoes%2Fman_lifestyle%2FMR530SG%2F&tbnid=2cTt5WiYYNc9bM&vet=12ahUKEwjKibuY7u_1AhVPr6QKHTmAA0sQMygBegUIARCvAg..i&docid=5P4wJ7bR6l6JVM&w=1659&h=942&q=new%20balance&hl=ru&client=opera&ved=2ahUKEwjKibuY7u_1AhVPr6QKHTmAA0sQMygBegUIARCvAg",
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