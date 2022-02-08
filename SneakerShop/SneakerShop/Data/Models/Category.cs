using System.Collections.Generic;

namespace SneakerShop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Desc{ get; set; }

        public List<Sneaker> Sneakers { get; set; }
    }
}