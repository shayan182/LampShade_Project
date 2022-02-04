using System;
using System.Collections.Generic;
using System.Linq;
using _01_LampshadeQuery.Contracts.Chart;
using AccountManagement.Infrastructure.EFCore;
using BlogManagement.Infrastructure.EFCore;
using SopManagement.Infrastructure.EFCore;

namespace _01_LampshadeQuery.Query
{
    public class ChartQuery : IChartQuery
    {
        private readonly AccountContext _accountContext;
        private readonly ShopContext _shopContext;
        private readonly BlogContext _blogContext;
        public ChartQuery(AccountContext accountContext, ShopContext shopContext, BlogContext blogContext)
        {
            _accountContext = accountContext;
            _shopContext = shopContext;
            _blogContext = blogContext;
        }

        public int GetCurrentUsersCount()
        {
            return _accountContext.Accounts.Count();
        }

        public double TotalSales()
        {
            var query = _shopContext.Order.Select(x => x.PayAmount);
            double totalSales = 0;
            foreach (var payAmount in query)
            {
                totalSales += payAmount;
            }

            return totalSales;
        }

        public int NewOrdersCount()
        {
            return _shopContext.Order.Count(x => x.CreationDate == DateTime.Now);
        }

        public int ArticleCount()
        {
            return _blogContext.Articles.Count();
        }

        public Chart PaymentMethodChart()
        {
            var query = _shopContext.Order.Select(x => new { x.PaymentMethod });
            int onlineMethod = 0, cashMethod = 0;
            foreach (var method in query)
            {
                if (method.PaymentMethod == 1)
                {
                    onlineMethod += 1;
                }
                else
                {
                    cashMethod += 1;
                }
            }

            return new Chart()
            {
                Label = "نحوه خرید",
                Data = new List<int> { onlineMethod, cashMethod },
                BackgroundColor = new List<string> { "#e76f51", "#0a9396" },
                BorderColor = "#4a4e69"
            };
        }

        public Chart SellChart()
        {
            var query = _shopContext.Order.Select(x => new { x.PayAmount, x.CreationDate });
            var agoDay = DateTime.Now.AddDays(-6);
            int payAmount = 0;
            List<int> data = new List<int>(4);
            for (var i = agoDay; i < DateTime.Now; i = i.AddDays(1))
            {
                foreach (var order in query)
                {
                    if (order.CreationDate.Day == i.Day)
                    {
                        payAmount += Convert.ToInt32(order.PayAmount);
                    }
                }
                data.Add(payAmount);
                payAmount = 0;
            }
            return new Chart()
            {
                Label = "فروش",
                Data = data,
                BackgroundColor = new List<string> { "#e76f51", "#0a9396" , "#a8dadc", "#e63946", "#800f2f", "#bc6c25"},
                BorderColor = "#4a4e69"
            }; 
        }

        public Chart ProductCategoryChart()
        {
            var categories = _shopContext.ProductCategories.Select(x => x.Id ).ToList();
            var products = _shopContext.Products.Select(x => x.CategoryId).ToList();
            var Count = 0;
            var data = new List<int>();
            foreach (var category in categories)
            {
                var categoryId = Convert.ToUInt32(category);
                foreach (var product in products)
                {
                    var productCategoryId = Convert.ToUInt64(product);
                    if (categoryId == productCategoryId)
                    {
                        Count++;
                    }
                }
                data.Add(Count);
                Count = 0;
            }

            return new Chart()
            {
                Label = "temp",
                Data = data,
                BackgroundColor = new List<string> { "#0081a7", "#00afb9", "#fdfcdc", "#fed9b7", "#f07167", "#424b54", "#b38d97" },
                BorderColor = "#4a4e69"
            };
        }

        public List<string> ProductCategoriesName()
        {
            var categories = _shopContext.ProductCategories.Select(x => x.Name).ToList();
            return categories.ToList();
        }
    }
}
