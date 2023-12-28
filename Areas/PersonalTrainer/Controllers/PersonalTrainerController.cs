using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.PersonalTrainer.Controllers
{
    public class PersonalTrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
