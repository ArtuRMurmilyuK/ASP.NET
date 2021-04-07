using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubSite.Data.Interfaces;
using ClubSite.ViewModels;

namespace ClubSite.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IAllPersons _allPersons;
        private readonly IPersonsCategory _personsCategory;

        public PersonsController(IAllPersons iAllPersons, IPersonsCategory iPersonsCategory)
        {
            _allPersons = iAllPersons;
            _personsCategory = iPersonsCategory;
        }
        
        public ViewResult ListAllPerson()
        {
            ViewBag.Title = "Страница с претендентами";
            PersonListViewModel obj = new PersonListViewModel();
            obj.GetAllPersons = _allPersons.Persons;
            obj.currCategory = "Люди";
            return View(obj);
        }
    }
}
