using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Data;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;

namespace SneakerShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders _orders;
        private readonly ShopCart _shopCart; 
        private readonly AppDBContent _appDBContent;

        public OrderController(IOrders orders, ShopCart shopCart, AppDBContent Db)
        {
            _appDBContent = Db;
            _orders = orders;
            _shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.ListShopItems = _shopCart.GetShopItems();

            if (_shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары!");
            }

            if (ModelState.IsValid)
            {
                _orders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }

        public IActionResult OrderList()
        {
            try
            {
                var orderList = _appDBContent.OrderDetail.ToList();

                return View(orderList);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}