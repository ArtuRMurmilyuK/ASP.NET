using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                return RedirectToAction("Error");
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

        public IActionResult Error()
        {
            ViewBag.Message = "У вас должны быть товары!";
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
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogIn model)
        {
            if (model.Password == "PavlovStar")
            {
                return RedirectToAction("OrderList");
            }
            else
            {
                ModelState.AddModelError(nameof(model.Password), "Пароль не вірний");
                return View(model);
            }
        }

        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                var order = await _appDBContent.OrderDetail.FindAsync(id);
                if (order != null)
                {
                    _appDBContent.Remove(order);
                    await _appDBContent.SaveChangesAsync();
                }

                return RedirectToAction("OrderList");
            }
            catch (Exception e)
            {
                return RedirectToAction("OrderList");
            }
        }
    }
}