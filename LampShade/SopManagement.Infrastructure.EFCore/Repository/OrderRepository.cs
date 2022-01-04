using System.Linq;
using _0_Framework.Infrastructure;
using ShopManagement.Domain.OrderAgg;

namespace SopManagement.Infrastructure.EFCore.Repository
{
    public class OrderRepository : RepositoryBase<long, Order> , IOrderRepository
    {
        private readonly ShopContext _context;
        public OrderRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public double GetAmountBy(long id)
        {
            var order = _context.Order.Select(x => new {x.Id, x.PayAmount}).FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
               return order.PayAmount;
            }

            return 0;
        }
    }
}
