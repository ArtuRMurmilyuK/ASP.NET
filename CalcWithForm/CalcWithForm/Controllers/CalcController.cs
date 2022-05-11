using Microsoft.AspNetCore.Mvc;

namespace CalcWithForm.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Forms(int Xvalue, int Yvalue, string action)
        {
            switch (action)
            {
                case "+":
                    ViewBag.Text = Xvalue + Yvalue;
                    break;
                case "-":
                    ViewBag.Text = Xvalue - Yvalue;
                    break;
                case "/":
                    ViewBag.Text = Xvalue / Yvalue;
                    break;
                case "*":
                    ViewBag.Text = Xvalue * Yvalue;
                    break;
            }
            
            return View();
        }
    }
}
