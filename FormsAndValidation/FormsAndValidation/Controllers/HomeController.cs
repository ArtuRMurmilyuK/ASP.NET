using FormsAndValidation.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationBildingModel model)
        {
            Debug.WriteLine(model.Name);
            Debug.WriteLine(model.Surname);
            Debug.WriteLine(model.Email);
            Debug.WriteLine(model.Date);

            if (model.Date.Day == 6 || model.Date.Day == 7)
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
