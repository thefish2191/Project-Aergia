using Microsoft.AspNetCore.Mvc;

namespace AngularProject.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
