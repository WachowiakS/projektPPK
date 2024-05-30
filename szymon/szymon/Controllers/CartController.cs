using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using szymon.Data;

[Authorize]
public class CartController : Controller
{
    private readonly ShoppingCartService _shoppingCartService;
    private readonly ApplicationDbContext _context;

    public CartController(ShoppingCartService shoppingCartService, ApplicationDbContext context)
    {
        _shoppingCartService = shoppingCartService;
        _context = context;
    }

    public IActionResult Index()
    {
        var cartItems = _shoppingCartService.GetCart();
        return View(cartItems);
    }

    [HttpPost]
    public IActionResult AddToCart(int productId)
    {
        var product = _context.Products.Find(productId);
        if (product == null)
        {
            return NotFound();
        }

        var item = new ShoppingCartItem
        {
            ProductId = productId,
            ProductName = product.Name,
            Price = product.Price,
            Quantity = 1
        };

        _shoppingCartService.AddToCart(item);

        return RedirectToAction("Index", "Cart");
    }

     [HttpPost]
    public IActionResult IncreaseQuantity(int cartItemId)
    {
        var cartItem = _shoppingCartService.GetCartItem(cartItemId);
        if (cartItem != null)
        {
            cartItem.Quantity++;
            _shoppingCartService.UpdateCartItem(cartItem);
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult DecreaseQuantity(int cartItemId)
    {
        var cartItem = _shoppingCartService.GetCartItem(cartItemId);
        if (cartItem != null)
        {
            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
                _shoppingCartService.UpdateCartItem(cartItem);
            }
            else
            {
                _shoppingCartService.RemoveFromCart(cartItemId);
            }
        }
        return RedirectToAction("Index");
    }

}
