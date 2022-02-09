using Microsoft.AspNetCore.Mvc;
using SneakerShop.Data.Interfaces;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class SneakersController : Controller
    {
        private readonly ISneakers _sneakers;
        private readonly ISneakersCategory _sneakersCategories;

        public SneakersController(ISneakers sneakers, ISneakersCategory sneakersCategories)
        {
            _sneakers = sneakers;
            _sneakersCategories = sneakersCategories;
        }

        public ViewResult Index()
        {
            SneakersListViewModel obj = new SneakersListViewModel();

            obj.GetSneakers = _sneakers.Sneakers;
            obj.CurrentCategory = "Кроссовки";

            return View(obj);
        }

    }
}