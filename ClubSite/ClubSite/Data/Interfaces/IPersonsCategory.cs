using System.Collections.Generic;
using ClubSite.Data.Models;

namespace ClubSite.Data.Interfaces
{
    public interface IPersonsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}