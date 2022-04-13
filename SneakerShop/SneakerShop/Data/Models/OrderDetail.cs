namespace SneakerShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SneakerId { get; set; }
        public uint Price { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string SneakerName { get; set; }
        public virtual Sneaker Sneaker { get; set; }
        public virtual Order Order { get; set; }
    }
}