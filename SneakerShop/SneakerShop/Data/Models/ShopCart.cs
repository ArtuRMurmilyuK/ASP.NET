using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SneakerShop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent _appDbContent;

        public ShopCart(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        // есть ли товар в корзине +1
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) {ShopCartId = shopCartId};
        }

        public void AddToCart(Sneaker sneaker)
        {
            _appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Sneaker = sneaker,
                Price = sneaker.Price
            });

            _appDbContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _appDbContent.ShopCartItem.Where(x => x.ShopCartId == ShopCartId).Include(s => s.Sneaker).ToList();
        }
    }
}