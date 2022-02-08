using System.Collections.Generic;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Mocks
{
    public class MockCategory : ISneakersCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryName = "Nike", Desc = "Кроссовки Nike"},
                new Category {CategoryName = "Jordan", Desc = "Кроссовки Jordan"},
                new Category {CategoryName = "Ugg", Desc = "Ботинки"},
                new Category {CategoryName = "Adidas", Desc = "Три полоски Adidas"},
                new Category {CategoryName = "New Balance", Desc = "Кроссовки для спорта"},
            };
    }
}