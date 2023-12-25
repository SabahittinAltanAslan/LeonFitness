using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
