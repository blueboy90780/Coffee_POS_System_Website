using Coffee_POS_System_ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_POS_System_ASP.NET_Core.Controllers
{
    public class HelloWorldController : Controller
    {
        // Fields
        private static List<DogViewModel> dogList = new();

        public IActionResult Index()
        {
            return View(dogList); //Will use the view that has the same name as this method inside the same folder as controller
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogList.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
