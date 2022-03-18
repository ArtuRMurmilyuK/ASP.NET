using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Data;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class SneakersController : Controller
    {
        private readonly ISneakers _sneakers;
        private readonly ISneakersCategory _sneakersCategories;
        private readonly AppDBContent _appDBContent;

        public SneakersController(ISneakers sneakers, ISneakersCategory sneakersCategories, AppDBContent appDbContent)
        {
            _sneakers = sneakers;
            _sneakersCategories = sneakersCategories;
            _appDBContent = appDbContent;
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
                    sneakers = _sneakers.Sneakers.Where(i => i.CategoryId == 1).OrderBy(i => i.Id);
                    currCategory = "Adidas";
                }
                if(string.Equals("Nike", category, StringComparison.OrdinalIgnoreCase))
                {
                    sneakers = _sneakers.Sneakers.Where(i => i.CategoryId == 2).OrderBy(i => i.Id);
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

        public IActionResult SneakersList()
        {
            try
            {
                //var sneakerList = _sneakers.Sneakers.ToList();
                var sneakerList = _appDBContent.Sneakers.ToList();
                return View(sneakerList);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult Create()
        {
            LoadCategory();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSneaker(Sneaker obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (obj.Id == 0)
                    { 
                        _appDBContent.Sneakers.Add(obj);
                        await _appDBContent.SaveChangesAsync();
                    }

                    return RedirectToAction("SneakersList");
                }
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("SneakersList");
            }
        }

        private void LoadCategory()
        {
            try
            {
                List<Category> categoriesList = new List<Category>();
                categoriesList = _appDBContent.Categories.ToList();

                categoriesList.Insert(0, new Category{Id = 0, CategoryName = "Select Category"});

                ViewBag.CatList = categoriesList;
            }
            catch (Exception e)
            {
                
            }
        }
    }
}