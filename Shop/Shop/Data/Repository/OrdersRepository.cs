using System;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
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
            _appDbContent.Order.Add(order);

            var items = _shopCart.ListShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = el.Car.Id,
                    OrderId = order.Id,
                    Price = el.Car.Price
                };

                _appDbContent.OrderDetail.Add(orderDetail);
            }

            _appDbContent.SaveChanges();
        }
    }
}