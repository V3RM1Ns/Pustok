using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers;

public class BookController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
 
    
}