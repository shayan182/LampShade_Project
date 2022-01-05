﻿using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Order
{
    public class Cart
    {
        public double TotalMount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayAmount { get; set; }
        public int PaymentMethod { get; private set; }
        public List<CartItem> Items { get; set; }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void Add(CartItem cartItem)
        {
            Items.Add(cartItem);
            TotalMount += cartItem.TotalItemPrice;
            DiscountAmount += cartItem.DiscountAmount;
            PayAmount += cartItem.ItemPayAmount;
        }

        public void SetPaymentMethod(int methodId)
        {
            PaymentMethod = methodId;
        }
    }
}