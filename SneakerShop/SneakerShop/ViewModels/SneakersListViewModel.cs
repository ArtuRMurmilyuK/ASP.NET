using System.Collections.Generic;
using SneakerShop.Data.Models;

namespace SneakerShop.ViewModels
{
    public class SneakersListViewModel
    {
        public IEnumerable<Sneaker> GetSneakers { get; set; }
        public string CurrentCategory { get; set; } 
    }
}