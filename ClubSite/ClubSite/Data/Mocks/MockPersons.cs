using System.Collections.Generic;
using System.Linq;
using ClubSite.Data.Interfaces;
using ClubSite.Data.Models;

namespace ClubSite.Data.Mocks
{
    public class MockPersons : IAllPersons
    {
        private readonly IPersonsCategory _categoryPersons = new MockCategory();
        public IEnumerable<Person> Persons
        {
            get
            {
                return new List<Person>
                {
                    new Person
                    {
                        Name = "Ольга", 
                        Surname = "Борькова", 
                        Age = 23, 
                        Gender = "Женщина", 
                        City = "Одесса", 
                        AboutMyself = "Весёлая, умная, умею слушать",
                        Description = "Ищу мужчину для приятных вечеров", 
                        Img = "/img/G20.jpg", 
                        IsFavorite = true, 
                        Category = _categoryPersons.AllCategories.First()
                    },
                    new Person
                    {
                        Name = "Петр", 
                        Surname = "Мальбертович", 
                        Age = 40, 
                        Gender = "Мужчина", 
                        City = "Киев", 
                        AboutMyself = "Просто Пётр =)",
                        Description = "Ищу женщину для тайных встреч", 
                        Img = "/img/M40.jpg",
                        IsFavorite = true, 
                        Category = _categoryPersons.AllCategories.First()
                    },
                    new Person
                    {
                        Name = "Олег", 
                        Surname = "Мартьянов", 
                        Age = 30, 
                        Gender = "Мужчина", 
                        City = "Львов", 
                        AboutMyself = "Люблю спорт, ищу спутницу по жизни",
                        Description = "Ищу женщину для тайных встреч", 
                        Img = "/img/M30.jpg", 
                        IsFavorite = true, 
                        Category = _categoryPersons.AllCategories.First()
                    },
                    new Person
                    {
                        Name = "Анастасия",
                        Surname = "Борисова",
                        Age = 40,
                        Gender = "Женщина",
                        City = "Винница",
                        AboutMyself = "Люблю спорт, ищу спутника по жизни",
                        Description = "Ищу мужчину, для светлого будущего",
                        Img = "/img/G40.jpg",
                        IsFavorite = true,
                        Category = _categoryPersons.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Person> GetFavPersons { get; set; }
        public Person GetObjectPerson(int personId)
        {
            throw new System.NotImplementedException();
        }
    }
}