using FlowStock_Backend.Data;
using FlowStock_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FlowStock_Backend.Pages.StockMovements
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StockMovement StockMovement { get; set; } = new StockMovement();

        public List<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }

        public IActionResult OnPost()
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == StockMovement.ProductId);

            if (product == null)
            {
                Products = _context.Products.ToList();
                return Page();
            }

            if (StockMovement.Type == "IN")
            {
                product.Quantity += StockMovement.Quantity;
            }
            else if (StockMovement.Type == "OUT" || StockMovement.Type == "LOSS")
            {
                product.Quantity -= StockMovement.Quantity;
            }

            _context.StockMovements.Add(StockMovement);

            if (product.Quantity <= product.MinimumStock)
            {
                var alert = new Alert
                {
                    ProductId = product.Id,
                    Type = "LowStock",
                    Message = $"Product {product.Name} is at low stock."
                };

                _context.Alerts.Add(alert);
            }

            _context.SaveChanges();

            return RedirectToPage("/Products/Index");
        }
    }
}