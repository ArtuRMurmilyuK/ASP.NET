using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory; 
        }
        // GET
        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";

            CarsListViewModel obj = new CarsListViewModel();

            obj.AllCars = _allCars.Cars;
            obj.CurrCategory = "Cars";
            return View(obj); 
        }
    }
}