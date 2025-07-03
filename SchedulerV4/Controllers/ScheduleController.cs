using Microsoft.AspNetCore.Mvc;

namespace SchedulerV4.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index(string group)
        {
            ViewData["Group"] = group;
            return View("schedule");
        }
    }
}
