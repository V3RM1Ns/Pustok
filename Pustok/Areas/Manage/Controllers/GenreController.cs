using Microsoft.AspNetCore.Mvc;
using Pustok.Data;

namespace Pustok.Areas.Manage.Controllers;

public class GenreController : Controller
{
    // GET
    public IActionResult Index(AppDbContext db)
    {
        var genres = db.Genres.ToList();
        return View(genres);
    }
}