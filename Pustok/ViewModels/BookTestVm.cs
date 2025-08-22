using Pustok.Models;

namespace Pustok.ViewModels;

public class BookTestVm:BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int DiscountPrice { get; set; }
    public bool IsNew { get; set; }
    public bool InStock { get; set; }
    public bool IsFeatured { get; set; }
    public string MainImage { get; set; }
    public string HoverImage { get; set; }
    public string AuthorName { get; set; }
    public string GenreName { get; set; }
    public List<string> BookTagNames { get; set; }
    public List<string> BookImages { get; set; }
    
    
}