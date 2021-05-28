﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;

using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i=>i.Id == id);
            
            if (item !=null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}