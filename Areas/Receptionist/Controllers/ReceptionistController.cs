using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Receptionist.Controllers
{
    public class ReceptionistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
