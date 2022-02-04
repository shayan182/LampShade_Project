using System;
using System.Collections.Generic;
using System.Linq;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CartModel : PageModel
    {
        public const string CookieName = "cart-items";
        public List<CartItem> CartItems { get; set; }
        private readonly IProductQuery _productQuery;

        public CartModel(IProductQuery productQuery)
        {
            CartItems = new List<CartItem>();
            _productQuery = productQuery;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            if (cartItems != null)
            {
                foreach (var item in cartItems)
                    item.CalculateTotalItemPrice();

                CartItems = _productQuery.CheckInventoryStatus(cartItems);
            }
        }
        public IActionResult OnGetRemoveFromCart(long id)
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            Response.Cookies.Delete(CookieName);
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            var itemToRemove = cartItems.FirstOrDefault(x => x.Id == id);
            cartItems.Remove(itemToRemove);
            var options = new CookieOptions { Expires = DateTime.Now.AddDays(2) , Path = "/",SameSite = SameSiteMode.None};
            Response.Cookies.Append(CookieName, serializer.Serialize(cartItems), options);

            //HttpContext.Response.Cookies.Append("user_id", "1");

            return RedirectToPage("/Cart");
        }

        public IActionResult OnGetGoToCheckout()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in CartItems)
            {
                item.TotalItemPrice = item.Price * item.Count;
            }

            CartItems = _productQuery.CheckInventoryStatus(cartItems);
            return RedirectToPage(CartItems.Any(x => !x.IsInStock) ? "/Cart" : "/Checkout");
        }
    }
}
