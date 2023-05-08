using Microsoft.AspNetCore.Mvc;

namespace TopSolution.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
