using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Veresi.Models;

namespace Veresi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string? categoryFilter)
        {
            var data = await _context.people
                .Include(p => p.Debts)
                .Include(p => p.Category)
                .ToListAsync();
            ViewBag.Categories = await _context.categories.ToListAsync();

            if(categoryFilter != null)
            {
                data = data.Where(x => x.Category.CategoryType == categoryFilter).ToList();
            }

            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
