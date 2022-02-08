using System.Collections.Generic;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Interfaces
{
    public interface ISneakersCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}