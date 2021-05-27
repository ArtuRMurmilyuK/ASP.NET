using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) 
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Cars.Any())
            {
                content.AddRange(
                    new Car {
                    Name = "Tesla",
                    ShortDesc = "Быстрый автомобиль",
                    LongDesc = "Красивый, быстрый и очень тихий автомобиль",
                    Img =
                        "/img/Tesla.jpg",
                    Price = 45000,
                    IsFavourite = true,
                    Available = true,
                    Category = Categories["Электромобили"]
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
                    Category = Categories["Классические автомобили"]
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
                    Category =  Categories["Классические автомобили"]
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
                    Category = Categories["Классические автомобили"]
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
                    Category = Categories["Классические автомобили"]
                }
                );
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> _categoty;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categoty == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                        new Category {CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего згорания"}
                    };

                    _categoty = new Dictionary<string, Category>();
                    foreach (Category element in list)
                    {
                        _categoty.Add(element.CategoryName, element);
                    }
                }

                return _categoty;
            }
        }
    }
}