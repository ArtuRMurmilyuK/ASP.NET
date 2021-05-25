using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars =>
            new List<Car>
            {
                new Car
                {
                    Name = "Tesla",
                    ShortDesc = "Быстрый автомобиль",
                    LongDesc = "Красивый, быстрый и очень тихий автомобиль",
                    Img =
                        "/img/Tesla.jpg",
                    Price = 45000,
                    IsFavourite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.First()
                },
                new Car
                {
                    Name = "Ford Fiesta",
                    ShortDesc = "Тихий и спокойный",
                    LongDesc = "Хорошая семейная машина",
                    Img =
                        "/img/ford.jpg",
                    Price = 11000,
                    IsFavourite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                new Car
                {
                    Name = "BMW M3",
                    ShortDesc = "Любимая машина бандитов",
                    LongDesc = "Дерзкий выхлоп для любимых соседов",
                    Img =
                        "/img/BMW.jpg",
                    Price = 20000,
                    IsFavourite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                new Car
                {
                    Name = "Mercedes C class",
                    ShortDesc = "Комфорт наше всё",
                    LongDesc = "Лучшая машина для комфортной езды",
                    Img =
                        "/img/Mers.jpg",
                    Price = 35000,
                    IsFavourite = false,
                    Available = false,
                    Category = _categoryCars.AllCategories.Last()
                },
                new Car
                {
                    Name = "Nissan skyline",
                    ShortDesc = "Популярный Японец",
                    LongDesc = "Бандит ночных улиц Токио",
                    Img =
                        "/img/Nisan.jpg",
                    Price = 14000,
                    IsFavourite = true,
                    Available = true,
                    Category = _categoryCars.AllCategories.Last()
                }
            };

        public IEnumerable<Car> GetFavCars { get; set; }
        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}