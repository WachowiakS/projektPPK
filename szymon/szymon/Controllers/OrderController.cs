using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using szymon.Data;
using szymon.Migrations;
using szymon.Models;

[Authorize]
public class OrderController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ShoppingCartService _shoppingCartService;

    public OrderController(ApplicationDbContext context, ShoppingCartService shoppingCartService)
    {
        _context = context;
        _shoppingCartService = shoppingCartService;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitOrder(OrderViewModel model)
    {
        if (ModelState.IsValid)
        {
            var order = new Order
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                PaymentMethod = model.PaymentMethod,
                OrderDate = DateTime.Now
            };

            var cartItems = _shoppingCartService.GetCart();
            foreach (var item in cartItems)
            {
                var product = _context.Products.Find(item.ProductId);
                if (product != null)
                {
                    order.Products.Add(product);
                }
            }

            _context.Orders.Add(order);
            _context.SaveChanges();

            _shoppingCartService.ClearCart();

            return RedirectToAction("OrderHistory");
        }

        return View("PlaceOrder", model);
    }


    public IActionResult OrderHistory()
    {
        var orders = _context.Orders.Include(o => o.Products)
                                    .OrderByDescending(o => o.OrderDate)
                                    .ToList();

        return View(orders);
    }



    public IActionResult OrderConfirmation()
    {
        return View();
    }

    public IActionResult PlaceOrder()
    {
        return View();
    }
}
