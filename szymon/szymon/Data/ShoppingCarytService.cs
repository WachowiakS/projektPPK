using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using szymon.Data;

public class ShoppingCartService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;

    public ShoppingCartService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public void AddToCart(ShoppingCartItem item)
    {
        var cartList = GetCart();
        var cartItem = cartList.FirstOrDefault(x => x.ProductId == item.ProductId);

        if (cartItem == null)
        {
            cartList.Add(item);
        }
        else
        {
            cartItem.Quantity += item.Quantity;
        }

        SaveCart(cartList);
    }

    public void UpdateCartItem(ShoppingCartItem item)
    {
        var cartList = GetCart();
        var existingItem = cartList.FirstOrDefault(x => x.Id == item.Id);

        if (existingItem != null)
        {
            existingItem.Quantity = item.Quantity;
        }

        SaveCart(cartList);
    }

    public void RemoveFromCart(int cartItemId)
    {
        var cartList = GetCart();
        var cartItem = cartList.FirstOrDefault(x => x.Id == cartItemId);

        if (cartItem != null)
        {
            cartList.Remove(cartItem);
            SaveCart(cartList);
        }
    }
    public void ClearCart()
    {
        _session.Remove("ShoppingCart");
    }


    public ShoppingCartItem GetCartItem(int cartItemId)
    {
        var cartList = GetCart();
        return cartList.FirstOrDefault(x => x.Id == cartItemId);
    }

    public List<ShoppingCartItem> GetCart()
    {
        var cartJson = _session.GetString("ShoppingCart") ?? "[]";
        return JsonConvert.DeserializeObject<List<ShoppingCartItem>>(cartJson);
    }

    public void SaveCart(List<ShoppingCartItem> cart)
    {
        var cartJson = JsonConvert.SerializeObject(cart);
        _session.SetString("ShoppingCart", cartJson);
    }
}
