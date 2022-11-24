using Microsoft.AspNetCore.Mvc;

namespace Coffee_POS_System_ASP.NET_Core.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Will use the view that has the same name as this method inside the same folder as controller
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
