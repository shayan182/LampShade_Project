using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_LampshadeQuery.Contracts.Inventory;
using InventoryManagement.Infrastructure.EFCore;
using SopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class InventoryQuery : IInventoryQuery
    {
        private readonly InventoryContext _inventoryContext;
        private readonly ShopContext _shopContext;

        public InventoryQuery(InventoryContext inventoryContext, ShopContext shopContext)
        {
            _inventoryContext = inventoryContext;
            _shopContext = shopContext;
        }

        public StockStatus CheckStock(IsInStock command)
        {
            var inventory = _inventoryContext.Inventory.FirstOrDefault(x => x.ProductId == command.ProductId);
            if (inventory == null || inventory.CalculateCurrentCount() < command.Count)
            {
                var productName = _shopContext.Products.FirstOrDefault(x => x.Id == command.ProductId)?.Name;
                return new StockStatus()
                {
                    InStock = false,
                    ProductName = productName
                };
            } 
            return new StockStatus()
            {
                InStock = true
            };
        }
    }
}
