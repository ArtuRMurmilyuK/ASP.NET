using Microsoft.EntityFrameworkCore;
using SneakerShop.Data.Models;

namespace SneakerShop.Data
{
    public class AppDBContent : DbContext 
    {
        public AppDBContent( DbContextOptions<AppDBContent> options) : base(options) 
        {
        }

        public DbSet<Sneaker> Sneakers {get; set; }
        public DbSet<Category> Categories {get; set; }
        public DbSet<ShopCartItem> ShopCartItem {get; set; }
        public DbSet<Order> Orders {get; set; }
        public DbSet<OrderDetail> OrderDetail {get; set; }
    }
}