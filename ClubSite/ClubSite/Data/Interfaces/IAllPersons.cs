using System.Collections.Generic;
using ClubSite.Data.Models;

namespace ClubSite.Data.Interfaces
{
    public interface IAllPersons
    {
        IEnumerable<Person> Persons { get; }
        IEnumerable<Person> GetFavPersons { get; set; }
        Person GetObjectPerson(int personId);
    }
}