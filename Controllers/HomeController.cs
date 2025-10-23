using InventoryApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Controllers
{
    [Authorize(Roles = "User")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var products = await _db.Products
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();
            return View(products); // List<Product>
        }
    }
}
