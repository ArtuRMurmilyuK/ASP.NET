using Microsoft.AspNetCore.Mvc;

namespace CalcInUrl.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int x, int y)
        {
            var res = x + y;
            return View(res);
        }

        public IActionResult Mul(int x, int y)
        {
            var res = x * y;
            return View(res);
        }

        public IActionResult Div(int x, int y)
        {
            var res = x / y;
            return View(res);
        }

        public IActionResult Sub(int x, int y)
        {
            var res = x - y;
            return View(res);
        }
    }
}
