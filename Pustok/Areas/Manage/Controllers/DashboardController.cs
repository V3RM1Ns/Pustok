using Microsoft.AspNetCore.Mvc;

namespace Pustok.Areas.Manage.Controllers;

public class DashboardController : Controller
{
    [Area("Manage")]
    // GET
    public IActionResult Index()
    {
        return View();
    }
}