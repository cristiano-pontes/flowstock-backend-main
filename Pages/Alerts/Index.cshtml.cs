using FlowStock_Backend.Data;
using FlowStock_Backend.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FlowStock_Backend.Pages.Alerts
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Alert> Alerts { get; set; } = new List<Alert>();

        public void OnGet()
        {
            Alerts = _context.Alerts
                .Include(a => a.Product)
                .OrderByDescending(a => a.Date)
                .ToList();
        }
    }
}