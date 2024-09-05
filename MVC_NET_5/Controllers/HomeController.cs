using Microsoft.AspNetCore.Mvc;

namespace MVC_NET_5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // The default behavior will take us to a view with the same name as the controller
            // Overload: accept string as name for a new view
            // Overload: accept object from Model Class
            // Overload: accepts both
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
