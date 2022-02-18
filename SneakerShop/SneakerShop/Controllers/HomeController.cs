using Microsoft.AspNetCore.Mvc;
using SneakerShop.Data.Interfaces;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class HomeController : Controller
    {
        private ISneakers _sneakers;

        public HomeController(ISneakers sneakers)
        {
            _sneakers = sneakers;
        }

        public ViewResult Index()
        {
            var homeSneakers = new HomeViewModel
            {
                FavSneakers = _sneakers.GetFavSneakers
            };
            return View(homeSneakers);
        }
    }
}