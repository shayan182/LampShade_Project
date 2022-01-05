using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using _0_Framework.Application.ZarinPal;
using _01_LampshadeQuery.Contracts;
using _01_LampshadeQuery.Contracts.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartService _cartService;
        private readonly ICartCalculatorService _calculatorService;
        private readonly IProductQuery _productQuery;
        private readonly IOrderApplication _orderApplication;
        private readonly IZarinPalFactory _zarinPal;
        public CheckoutModel(ICartCalculatorService calculatorService, ICartService cartService, IProductQuery productQuery, IOrderApplication orderApplication, IZarinPalFactory zarinPal)
        {
            _calculatorService = calculatorService;
            _cartService = cartService;
            _productQuery = productQuery;
            _orderApplication = orderApplication;
            _zarinPal = zarinPal;
            Cart = new Cart();
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

       
        public IActionResult OnPostPay(int paymentMethod)
        {
            var cart = _cartService.Get();
            cart.SetPaymentMethod(paymentMethod);
            var result = _productQuery.CheckInventoryStatus(cart.Items);
            if (result.Any(x => !x.IsInStock))
                return RedirectToPage("./Cart");

            var orderId = _orderApplication.PlaceOrder(cart);
            if (cart.PaymentMethod == 1)
            {
                var paymentResponse = _zarinPal.CreatePaymentRequest(
                    cart.PayAmount.ToString(CultureInfo.InvariantCulture), "", "",
                    "خرید از درگاه لوازم خانگی و دکوری", orderId);


                return Redirect(
                    $"https://{_zarinPal.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");
            }

            var paymentResult = new PaymentResult();
            return RedirectToPage("/PaymentResult", paymentResult.Succeeded("سفارش شما با موفقیت ثبت شد. پس از تماس کارشناسان ما سفارش شما ارسال خواهد شد." ,null));
        }

        public IActionResult OnGetCallBack([FromQuery] string authority, [FromQuery] string status,
            [FromQuery] long oId)
        {
            var orderAmount = _orderApplication.GetAmountBy(oId);
            var verificationResponse = _zarinPal.CreateVerificationRequest
                (authority, orderAmount.ToString(CultureInfo.InvariantCulture));
            PaymentResult paymentResult = new PaymentResult();
            if (status == "OK" && verificationResponse.Status >= 100)
            {
                var issueTrackingNo = _orderApplication.PaymentSucceeded(oId, verificationResponse.RefID);
                Response.Cookies.Delete(CookieName);
                paymentResult = paymentResult.Succeeded("پرداخت با موفقیت انجام شد.", issueTrackingNo);
                return RedirectToPage("PaymentResult", paymentResult);
            }

            paymentResult = paymentResult.Failed("پرداخت با موفقیت انجام نشد.درصورت کسر وجه از حساب شما ، مبلغ تا 24 ساعت آینده به حساب شما بازگردانده خواهد شد.");
            return RedirectToPage("PaymentResult", paymentResult);
        }
    }
}
