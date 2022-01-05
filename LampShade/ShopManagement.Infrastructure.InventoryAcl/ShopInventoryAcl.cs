using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Application.Contract.Inventory;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.Services;

namespace ShopManagement.Infrastructure.InventoryAcl
{
    public class ShopInventoryAcl : IShopInventory
    {
        private readonly IInventoryApplication _inventoryApplication;

        public ShopInventoryAcl(IInventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }

        public bool ReduceFromInventory(List<OrderItem> orderItems)
        {
            var command = orderItems.Select(orderItem => 
                new ReduceInventory(orderItem.ProductId, orderItem.Count, "خرید مشتری", orderItem.OrderId)).ToList();

            return _inventoryApplication.Reduce(command).IsSuccedded;
        }
    }
}
