using System.Collections.Generic;
using System.Linq;
using _0_Framework.Domain;

namespace InventoryManagement.Domain.InventoryAgg
{
    public class Inventory : EntityBase
    {
        public long ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; private set; }
        public List<InventoryOperation> Operations { get; private set; }
        protected Inventory() { }

        public Inventory(double unitPrice, long productId)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            InStock = false;
        }
        public void Edit(double unitPrice, long productId)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            InStock = false;
        }

        public long CalculateCurrentCount()
        {
            var plus = Operations.Where(x => x.Operation).Sum(x => x.Count);
            var minus = Operations.Where(x => !x.Operation).Sum(x => x.Count);
            return plus - minus;
        }
        public void Increase(long count, long operatorId, string description)
        {
            var currentcount = CalculateCurrentCount() + count;
            var operation = new InventoryOperation(true, count, operatorId, currentcount
                , description, 0, Id);
            Operations.Add(operation);
            InStock = currentcount > 0;
        }
        public void Reduce(long count, long operatorId, string description, long orderId)
        {
            var currentcount = CalculateCurrentCount() - count;
            var operation = new InventoryOperation(false, count, operatorId, currentcount
                , description, orderId, Id);
            Operations.Add(operation);
            InStock = currentcount > 0;
        }
    }
}
