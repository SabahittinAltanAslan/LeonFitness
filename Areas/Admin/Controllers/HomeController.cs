using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
