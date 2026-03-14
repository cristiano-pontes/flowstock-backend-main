using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FlowStock_Backend.Models;
using FlowStock_Backend.Data;

namespace FlowStock_Backend.Pages.Suppliers
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Supplier Supplier { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Suppliers.Add(Supplier);
            _context.SaveChanges();

            return RedirectToPage("/Suppliers/Index");
        }
    }
}