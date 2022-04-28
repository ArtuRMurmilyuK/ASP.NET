using System;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Repository
{
    public class OrdersRepository : IOrders
    {
        private readonly AppDBContent _appDbContent;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDBContent appDbContent, ShopCart shopCart)
        {
            _appDbContent = appDbContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
           order.OrderTime = DateTime.Now;
           _appDbContent.Orders.Add(order);

           _appDbContent.SaveChanges();
           var items = _shopCart.ListShopItems;

           foreach (var el in items)
           {
               var orderDetail = new OrderDetail()
               {
                   SneakerId = el.Sneaker.Id,
                   OrderId = order.Id,
                   Price = el.Sneaker.Price,
                   Adress = order.Adress,
                   Name = order.Name,
                   Phone = order.Phone,
                   SneakerName = el.Sneaker.Name,
                   Surname = order.Surname,
                   SneakerSize = order.SneakerSizeOrder
               };
               _appDbContent.OrderDetail.Add(orderDetail); 
           }
           _appDbContent.SaveChanges();
        }
    }
}