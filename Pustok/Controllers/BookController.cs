using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;

namespace Pustok.Controllers;

public class BookController : Controller
{
    private readonly AppDbContext _context;

    public BookController(AppDbContext context)
    {
        _context = context;
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detail(int id)
    {
        var book = _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .Include(b => b.BookImages)
            .Include(b => b.BookTags)
                .ThenInclude(bt => bt.Tag)
            .FirstOrDefault(b => b.Id == id);

        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }
}