﻿namespace ShopManagement.Application.Contracts.Order
{
    public class CartItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public int Count { get; set; }
        public double TotalItemPrice { get; set; }
        public bool IsInStock { get; set; }
        public int DiscountRate { get; set; }
        public double DiscountAmount { get; set; }
        public double ItemPayAmount { get; set; }


        public CartItem()
        {
            TotalItemPrice = Price * Count;
        }

        public void CalculateTotalItemPrice()
        {
            TotalItemPrice = Price * Count ;
        }
    }
}