using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepInternetowy.Data;
using System.Threading.Tasks;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
    }
}
