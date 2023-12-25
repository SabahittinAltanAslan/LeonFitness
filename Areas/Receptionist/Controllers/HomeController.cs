using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Receptionist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
