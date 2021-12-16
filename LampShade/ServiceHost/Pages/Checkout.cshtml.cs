using System.Collections.Generic;
using System.Linq;
using _01_LampshadeQuery.Contracts;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartService _cartService;
        private readonly ICartCalculatorService _calculatorService;
        private readonly IProductQuery _productQuery;
        public CheckoutModel(ICartCalculatorService calculatorService, ICartService cartService, IProductQuery productQuery)
        {
            _calculatorService = calculatorService;
            _cartService = cartService;
            _productQuery = productQuery;
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            Cart = _calculatorService.ComputeCart(cartItems);
            _cartService.Set(Cart);
        }

        public IActionResult OnGetPay()
        {
            var cart = _cartService.Get();

            var result = _productQuery.CheckInventoryStatus(cart.Items);
            if (result.Any(x => !x.IsInStock ))
                return RedirectToPage("./Cart");

            return RedirectToPage("./Checkout");
        }
    }
}
