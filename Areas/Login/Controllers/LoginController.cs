using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
