using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Application.Contracts
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private PaymentMethod(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public static List<PaymentMethod> GetList()
        {
            return new List<PaymentMethod>
            {
                new PaymentMethod(1, "پرداخت اینترنتی", "در این مدل پرداخت شما به درگاه پرداخت هدایت شده و در لحظه پرداخت را انجام خواهدی داد."),
                new PaymentMethod(2, "پرداخت نقدی", "در این مدل،ابتدا سفارش ثبت شده و سپس وجه به صورت نقدی هنگام تحویل کالا دریافت خواهد شد."),
            };
        }

        public static PaymentMethod GetBy(int id)
        {
            return GetList().FirstOrDefault(x => x.Id == id);
        }
    }
}
