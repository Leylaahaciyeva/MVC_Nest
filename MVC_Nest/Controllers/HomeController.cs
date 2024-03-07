using Microsoft.AspNetCore.Mvc;

namespace MVC_Nest.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

