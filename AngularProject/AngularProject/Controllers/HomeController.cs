using Microsoft.AspNetCore.Mvc;

namespace AngularProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
