using System.Collections.Generic;
using SneakerShop.Data.Models;

namespace SneakerShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneaker> FavSneakers { get; set; }
    }
}