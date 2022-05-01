using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
