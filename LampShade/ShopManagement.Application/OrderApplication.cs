using _0_Framework.Application;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.Services;

namespace ShopManagement.Application
{
    public class OrderApplication : IOrderApplication
    {

        private readonly IAuthHelper _authHelper;
        private readonly IOrderRepository _orderRepository;
        private readonly IShopInventory _shopInventory;
        public OrderApplication(IOrderRepository orderRepository, IAuthHelper authHelper, IShopInventory shopInventory)
        {
            _orderRepository = orderRepository;
            _authHelper = authHelper;
            _shopInventory = shopInventory;
        }

        public long PlaceOrder(Cart cart)
        {
            var accountId = _authHelper.CurrentAccountId();
            var order = new Order(cart.PaymentMethod, accountId, cart.TotalMount, cart.DiscountAmount, cart.PayAmount);

            foreach (var cartItem in cart.Items)
            {
                var oderItem = new OrderItem(cartItem.Id, cartItem.Count, cartItem.DiscountAmount, cartItem.Price);
                order.AddItem(oderItem);
            }
            _orderRepository.Create(order);
            _orderRepository.SaveChanges();
            return order.Id;
        }

        public double GetAmountBy(long id)
        {
            return _orderRepository.GetAmountBy(id);
        }

        public string PaymentSucceeded(long orderId, long refId)
        {
            var order = _orderRepository.Get(orderId);
            order.PaymentSucceeded(orderId);
            var issueTrackingNo = CodeGenerator.Generate("s");
            order.SetIssueTrackingNo(issueTrackingNo);
            if (!_shopInventory.ReduceFromInventory(order.Items)) return "";
            _orderRepository.SaveChanges();
            return issueTrackingNo;

        }
    }
}
