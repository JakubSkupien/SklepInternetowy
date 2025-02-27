using SklepInternetowy.Data;
using SklepInternetowy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context) { _context = context; }

        public IActionResult Index() => View();

        public IActionResult ManageUsers() => View(_context.Users.ToList());

        public IActionResult ManageOrders() => View(_context.Orders.Include(o => o.OrderItems).ThenInclude(i => i.Product).ToList());

        [HttpPost]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, string status)
        {
            var order = _context.Orders.Find(orderId);
            if (order == null) return NotFound();
            order.Status = status;
            await _context.SaveChangesAsync();
            return RedirectToAction("ManageOrders");
        }
    }
}