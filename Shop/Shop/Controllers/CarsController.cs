using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
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
        
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(x => x.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else
                {
                    cars = _allCars.Cars.Where(x => x.Category.CategoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    currCategory = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Page with cars";

            return View(carObj); 
        }
    }
}