using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StartPage()
        {
            return View();
        }


        public IActionResult Schedule(string group)
        {
            ViewData["Group"] = group;
            return View("schedule");  // загружает Views/Home/schedule.cshtml
        }

    }
}
