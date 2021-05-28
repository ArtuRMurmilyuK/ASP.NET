using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDbContent;

        public ShopCart(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public string  ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) {ShopCartId = shopCartId};
        }

        public void AddToCart(Car car)
        {
            appDbContent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Car = car,
                Price = car.Price
            });

            appDbContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return appDbContent.ShopCartItems.Where(c => c.ShopCartId == ShopCartId)
                .Include(s => s.Car).ToList();
        }
    }
}