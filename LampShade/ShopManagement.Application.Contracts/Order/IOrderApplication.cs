using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Order
{
    public interface IOrderApplication
    {
        long PlaceOrder(Cart cart);
        double GetAmountBy(long id);
        void Cancel(long id);
        List<OrderItemViewModel> GetItems(long orderId);
        string PaymentSucceeded(long orderId, long refId);
        List<OrderViewModel> Search(OrderSearchModel searchModel);

    }
}
