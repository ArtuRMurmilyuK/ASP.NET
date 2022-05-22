using FormsAndValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            string[] items = { "JavaScript", "C#", "Java", "Python", "Основы" };
            SelectList selectList = new SelectList(items, items[2]);
            ViewBag.SelectItems = selectList;
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationBildingModel model)
        {
            Debug.WriteLine(model.Name);
            Debug.WriteLine(model.Surname);
            Debug.WriteLine(model.Email);
            Debug.WriteLine(model.Date.DayOfWeek);
            Debug.WriteLine(model.SelectItem);

            if(model.SelectItem == "Основы" && model.Date.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError(nameof(model.SelectItem), "Курсы по Основе не проводятся в понедельник");
            }
            else if (model.Date.DayOfWeek == DayOfWeek.Saturday || model.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                ModelState.AddModelError(nameof(model.Date), "Нельзя записаться на выходной день");
            }
            else if(model.Date.Date == DateTime.Today.Date)
            {
                ModelState.AddModelError(nameof(model.Date), "Нельзя записаться на Сегодня");
            }

            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View(model);
            }   
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
