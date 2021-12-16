using System.Runtime.InteropServices;
using _0_Framework.Application;
using Microsoft.Extensions.Configuration;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.OrderAgg;

namespace ShopManagement.Application
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IAuthHelper _authHelper;
        public OrderApplication(IOrderRepository orderRepository, IAuthHelper authHelper)
        {
            _orderRepository = orderRepository;
            _authHelper = authHelper;
        }

        public long PlaceOrder(Cart cart)
        {
            var accountId = _authHelper.CurrentAccountId();
            var order = new Order(accountId , cart.TotalMount , cart.DiscountAmount , cart.PayAmount );

            foreach (var cartItem in cart.Items)
            {
                var oderItem = new OrderItem(cartItem.Id, cartItem.Count, cartItem.DiscountAmount, cartItem.Price);
                order.AddItem(oderItem);
            }
            _orderRepository.Create(order);
            _orderRepository.SaveChanges();
            return order.Id;
        }

        public void PaymentSucceeded(long orderId, long refId)
        {
            var order = _orderRepository.Get(orderId);
            order.PaymentSucceeded(orderId);
            var issueTrackingNo = CodeGenerator.Generate("s");
            order.SetIssueTrackingNo(issueTrackingNo);
            _orderRepository.SaveChanges();
        }
    }
}
