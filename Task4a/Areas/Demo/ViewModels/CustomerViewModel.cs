using Microsoft.AspNetCore.Mvc;

namespace Task4.Areas.Demo.ViewModels
{
    public class CustomerViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
