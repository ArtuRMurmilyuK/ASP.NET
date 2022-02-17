namespace SneakerShop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Sneaker Sneaker { get; set; }
        public int Price { get; set; }
        public string ShopCartId { get; set; }
    }
}