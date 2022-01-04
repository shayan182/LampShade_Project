using _0_Framework.Application.ZarinPal;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class PaymentResultModel : PageModel
    {
        public PaymentResult PaymentResult { get; set; }    

        public void OnGet(PaymentResult result)
        {
            PaymentResult = result;
        }
    }
}
