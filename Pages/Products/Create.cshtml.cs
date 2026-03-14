using FlowStock_Backend.Data;
using FlowStock_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FlowStock_Backend.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; } = new Product();

        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public void OnGet()
        {
            Suppliers = _context.Suppliers.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
            return RedirectToPage("/Products/Index");
        }
    }
}