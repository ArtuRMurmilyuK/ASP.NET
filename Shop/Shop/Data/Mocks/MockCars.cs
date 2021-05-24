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
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEUsa9krZBZzIIuvztY2aNROJk5k3Tr-oh8w&usqp=CAU",
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
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWtifimIAuFk7q3A5Ii7HSYXc1Zw_Lv8mtCw&usqp=CAU",
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
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJU06aQs7s6YXGnj1c4Un-Kf0BV9NINVsI4Q&usqp=CAU",
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
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMWchenkl9keyBFeLpvd4vse8f_Hsu_Af36A&usqp=CAU",
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
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOa7QNkByov9nHzQ_aEGyjpoSKND2xK3pOhg&usqp=CAU",
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