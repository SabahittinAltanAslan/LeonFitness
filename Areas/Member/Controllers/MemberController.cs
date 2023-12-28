using Microsoft.AspNetCore.Mvc;

namespace LeonFitness.Areas.Member.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddMember()
        {
            return View();
        }
    }
}
