using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Infrastructure.EFCore;
using ShopManagement.Application.Contracts;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.OrderAgg;

namespace SopManagement.Infrastructure.EFCore.Repository
{
    public class OrderRepository : RepositoryBase<long, Order> , IOrderRepository
    {
        private readonly AccountContext _accountContext;
        private readonly ShopContext _context;
        public OrderRepository(ShopContext context, AccountContext accountContext) : base(context)
        {
            _context = context;
            _accountContext = accountContext;
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

        public List<OrderViewModel> Search(OrderSearchModel searchModel)
        {
            var account = _accountContext.Accounts.Select(x => new {x.Id ,x.Fullname }).ToList();
            var query = _context.Order.Select(x=> new OrderViewModel()
            {
                Id = x.Id,
                AccountId = x.AccountId,
                IsCanceled = x.IsCanceled,
                CreationDate = x.CreationDate.ToFarsi(),
                DiscountAmount = x.DiscountAmount,
                IsPaid = x.IsPaid,
                IssueTrackingNo = x.IssueTrackingNo,
                PayAmount = x.PayAmount,
                PaymentMethodId = x.PaymentMethod,
                TotalAmount = x.TotalAmount,
                RefId = x.RefId
            });

            query = query.Where(x => x.IsCanceled == searchModel.IsCanceled);

            if (searchModel.AccountId > 0) query = query.Where(x => x.AccountId == searchModel.AccountId);

            var orders = query.OrderByDescending(x => x.Id).ToList();

            foreach (var order in orders)
            {
                order.AccountFullname = account.FirstOrDefault(x => x.Id == order.AccountId)?.Fullname;
                order.PaymentMethod = PaymentMethod.GetBy(order.PaymentMethodId).Name;
            }

            return orders;
        }
    }
}
