using System.Collections.Generic;
using System.Drawing;

namespace SneakerShop.Data.Models
{
    public class Sneaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Season { get; set; }
        public string Img { get; set; }
        public ushort Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public string Size { get; set; }
        public string Gender { get; set; }
        public virtual Category Category { get; set; }
        public SizeSneaker SizeSneakers { get; set; } 
    }
}