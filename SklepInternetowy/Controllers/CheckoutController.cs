using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;

namespace SklepInternetowy.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var cart = new Cart
            {
                UserId = "test-user", 
                CartItems = new List<CartItem>
                {
                    new CartItem
                    {
                        Product = new Product { Name = "Sample Product", Price = 10.99M },
                        Quantity = 2
                    }
                }
            };

            return View(cart);
        }
    }
}
