using Microsoft.AspNetCore.Mvc.RazorPages;
using FlowStock_Backend.Data;
using FlowStock_Backend.Models;

namespace FlowStock_Backend.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Supplier> Suppliers { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Suppliers = _context.Suppliers.ToList();
        }
    }
}