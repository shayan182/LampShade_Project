using System.Collections.Generic;
using ShopManagement.Domain.OrderAgg;

namespace ShopManagement.Domain.Services
{
    public interface IShopInventory
    {
        bool ReduceFromInventory(List<OrderItem> orderItems);
    }
}
