using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
