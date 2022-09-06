using Microsoft.AspNetCore.Mvc;
using MyASPDemos.Areas.Demo.ViewModels;

namespace MyASPDemos.Areas.Demo.Controllers
{
    [Area("Demo")]                  // Register the Route for the Controller to the Area
    public class HomeController : Controller
    {
        // HTTP GET https://localhost:xxxx/Demo
        // HTTP GET https://localhost:xxxx/Demo/Home
        // HTTP GET https://localhost:xxxx/Demo/Home/Index
        // ROUTE: url / {area} / {controller} / {action}
        public IActionResult Index()
        {
            return Ok("Hello world");               // HTTP Response 200 "Ok"
        }
        // HTTP GET https://localhost:xxxx/Demo/Home/Index2
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult DisplayCustomer()
        {
            CustomerViewModel obj = new CustomerViewModel();
            return View(obj);
        }
    }
}