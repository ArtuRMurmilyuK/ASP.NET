using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;
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

        [Route("Sneakers/Index")]
        [Route("Sneakers/Index/{category}")]
        public ViewResult Index(string category)
        {
            IEnumerable<Sneaker> sneakers = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                sneakers = _sneakers.Sneakers.OrderBy(i => i.Id);
            }
            else
            {
                //TODO: for UGG, NB and other
                if (string.Equals("Adidas", category, StringComparison.OrdinalIgnoreCase))
                {
                    sneakers = _sneakers.Sneakers.Where(i => i.Category.CategoryName.Equals("Adidas")).OrderBy(i => i.Id);
                    currCategory = "Adidas";
                }
                if(string.Equals("Nike", category, StringComparison.OrdinalIgnoreCase))
                {
                    sneakers = _sneakers.Sneakers.Where(i => i.Category.CategoryName == category);
                    currCategory = "Nike";
                }
            }

            var sneakerObj = new SneakersListViewModel
            {
                GetSneakers = sneakers,
                CurrentCategory = currCategory
            };

            return View(sneakerObj);
        }

    }
}