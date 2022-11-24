using Coffee_POS_System_ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_POS_System_ASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {
        // Fields
        private readonly ILogger<HomeController> _logger;

        // Constructor
        public HomeController(
            ILogger<HomeController> logger
            )
        {
            // IoC Code = Set value of class in here
            _logger = logger;
        }

        // Index Page
        // IActionResult = The buttons that we can click on which leads to a page.
        // Each IActionResult method will return a view corresponding to the page controller for example, Home/Index.cshtml for Index() and
        // Home/Privacy.cshtml for Privacy()
        public IActionResult Index()
        {
            return View();
        }

        // Privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}