using System.Collections.Generic;
using ClubSite.Data.Interfaces;
using ClubSite.Data.Models;

namespace ClubSite.Data.Mocks
{
    public class MockCategory : IPersonsCategory
    {
        public IEnumerable<Category> AllCategories {
            get{
                return new List<Category> {
                    new Category{CategoryName = "Мужчины"},
                    new Category{CategoryName = "Женщины"},
                    new Category{CategoryName = "Одесса", Desc = "Из города Одесса"},
                    new Category{CategoryName = "Киев", Desc = "Из города Киев"},
                    new Category{CategoryName = "Винница", Desc = "Из города Винница"},
                    new Category{CategoryName = "Львов", Desc = "Из города Львов"}
                };

            }
        }
    }
}