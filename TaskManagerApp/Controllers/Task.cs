using Microsoft.AspNetCore.Mvc;

namespace TaskManagerApp.Controllers
{
    public class Task : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
