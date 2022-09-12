using Microsoft.AspNetCore.Mvc;

namespace Task4a.Areas.Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
