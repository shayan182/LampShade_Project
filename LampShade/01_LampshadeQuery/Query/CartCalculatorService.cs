using System;
using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts;
using DiscountManagement.Infrastructure.EFCore;
using ShopManagement.Application.Contracts.Order;

namespace _01_LampshadeQuery.Query
{
    public class CartCalculatorService : ICartCalculatorService
    {
        private readonly IAuthHelper _authHelper;
        private readonly DiscountContext _discountContext;

        public CartCalculatorService(DiscountContext discountContext, IAuthHelper authHelper)
        {
            _discountContext = discountContext;
            _authHelper = authHelper;
        }

        public Cart ComputeCart(List<CartItem> cartItems)
        {
            var cart = new Cart();
            var colleagueDiscounts = _discountContext.ColleagueDiscounts
                .Where(x => !x.IsRemoved)
                .Select(x => new { x.ProductId, x.DiscountRate })
                .ToList();

            var customerDiscounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
              .Select(x => new { x.ProductId, x.DiscountRate })
              .ToList();

            var currentAccountRole = _authHelper.CurrentAccountRole();

            foreach (var item in cartItems)
            {
                if(currentAccountRole == Roles.ColleagueUser)
                {
                    var colleagueDiscount = colleagueDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (colleagueDiscount != null)
                    {
                        item.DiscountRate = colleagueDiscount.DiscountRate;

                    }
                }
                else
                {
                    var customerDiscount = customerDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
                    if (customerDiscount != null)
                    {
                        item.DiscountRate = customerDiscount.DiscountRate;
                    }
                }
                item.DiscountAmount = ((item.DiscountRate * item.TotalItemPrice) / 100);
                item.ItemPayAmount = item.TotalItemPrice - item.DiscountAmount;
                cart.Add(item);
            }

            return cart;


            // bad code 

            //if (currentAccountRole == Roles.ColleagueUser)
            //{
            //    foreach (var item in cartItems)
            //    {
            //        var colleagueDiscount = colleagueDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
            //        if(colleagueDiscount == null) continue;
            //        item.DiscountRate = colleagueDiscount.DiscountRate;
            //        item.DiscountAmount = ((item.DiscountRate * item.DiscountAmount) / 100);
            //        item.ItemPayAmount = item.TotalItemPrice - item.DiscountAmount;
            //        cart.Add(item);
            //    }
            //}
            //else
            //{
            //    foreach (var item in cartItems)
            //    {
            //        var customerDiscount = customerDiscounts.FirstOrDefault(x => x.ProductId == item.Id);
            //        if (customerDiscount == null) continue;
            //        item.DiscountRate = customerDiscount.DiscountRate;
            //        item.DiscountAmount = ((item.DiscountRate * item.DiscountAmount) / 100);
            //        item.ItemPayAmount = item.TotalItemPrice - item.DiscountAmount;
            //        cart.Add(item);
            //    }
            //}
            //return cart;
        }
    }
}