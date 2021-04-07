using System.Collections.Generic;
using ClubSite.Data.Models;

namespace ClubSite.ViewModels
{
    public class PersonListViewModel
    {
        public IEnumerable<Person> GetAllPersons { get; set; }

        public string currCategory { get; set; }
    }
}