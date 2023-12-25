using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.PersonalTrainer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
