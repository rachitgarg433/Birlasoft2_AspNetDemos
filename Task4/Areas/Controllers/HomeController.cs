using Microsoft.AspNetCore.Mvc;

namespace Task4.Areas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
