using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SneakerShop.Data.Models;

namespace SneakerShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Sneakers.Any())
            {
                content.AddRange(
                    new Sneaker
                    {
                        Name = "Nike Air2",
                        Season = "Лето",
                        Img = "/img/ar99.jpg",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Nike"],
                    },
                    new Sneaker
                    {
                        Name = "Nike Air221",
                        Season = "Лето",
                        Img = "/img/ar99207.jpg",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Nike"],
                    }, 
                    new Sneaker
                    {
                        Name = "Nike Air221",
                        Season = "Лето",
                        Img = "/img/ar99327.jpg",
                        Price = 1460,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Nike"],
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Nike", Desc = "Модный найк"},
                        new Category {CategoryName = "Adidas", Desc = "Adik for me"}
                    };

                    _categories = new Dictionary<string, Category>();
                    foreach (var el in list)
                    {
                        _categories.Add(el.CategoryName, el);
                    }
                }

                return _categories;
            }
        }
    }
}