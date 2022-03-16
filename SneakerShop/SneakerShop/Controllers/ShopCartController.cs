using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly ISneakers _sneaker;
        private readonly ShopCart _shopCart;

        public ShopCartController(ISneakers sneaker, ShopCart shopCart)
        {
            _sneaker = sneaker;
            _shopCart = shopCart;
        }

        //New list Sneakes or just add Sneakers.Name??
        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel {ShopCart = _shopCart};
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _sneaker.Sneakers.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}