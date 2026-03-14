using FlowStock_Backend.Data;
using FlowStock_Backend.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FlowStock_Backend.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            Products = _context.Products
                .Include(p => p.Supplier)
                .ToList();
        }
    }
}