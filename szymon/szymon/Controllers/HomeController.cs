// HomeController.cs
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using szymon.Data;

namespace szymon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // Inne metody kontrolera...
    }
}
