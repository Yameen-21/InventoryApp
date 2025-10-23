using InventoryApp.Data;
using InventoryApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace InventoryApp.Controllers
{
    [Authorize(Roles = "User")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _db;
        public OrderController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> Create(int id) // id = productId
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int productId, int quantity, string? notes)
        {
            var product = await _db.Products.FindAsync(productId);
            if (product == null || quantity <= 0 || quantity > product.Quantity)
            {
                TempData["Error"] = "Invalid quantity or product.";
                return RedirectToAction("Index", "Home");
            }

            var email = User.FindFirstValue(ClaimTypes.Email);
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null) return Unauthorized();

            var order = new Order
            {
                UserId = user.Id,
                ProductId = product.Id,
                Quantity = quantity,
                TotalPrice = product.Price * quantity,
                Status = "Pending",
                Notes = notes?.Trim() ?? string.Empty,
                OrderedAt = DateTime.Now
            };

            // reduce stock
            product.Quantity -= quantity;

            _db.Orders.Add(order);
            await _db.SaveChangesAsync();

            TempData["Success"] = "Order placed successfully!";
            return RedirectToAction("Index", "Home");
        }
    }
}
