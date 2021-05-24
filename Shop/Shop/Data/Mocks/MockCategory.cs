using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                new Category {CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего згорания"}
            };
    }
}