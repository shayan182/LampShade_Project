using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Chart;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages
{
    public class IndexModel : PageModel
    {
        public int UsersCount;
        public double TotalSales;
        public int ArticleCount;
        public int NewOrdersCount;
        public Chart PaymentMethod;
        public Chart Sell;
        public Chart ProductCategories;
        public List<string> ProductCategoriesName;
        private readonly IChartQuery _chartQuery;

        public IndexModel(IChartQuery chartQuery)
        {
            _chartQuery = chartQuery;
        }

        public void OnGet()
        {
            UsersCount = _chartQuery.GetCurrentUsersCount();
            PaymentMethod = _chartQuery.PaymentMethodChart();
            TotalSales = _chartQuery.TotalSales();
            NewOrdersCount = _chartQuery.NewOrdersCount();
            ArticleCount = _chartQuery.ArticleCount();
            Sell = _chartQuery.SellChart();
            ProductCategories = _chartQuery.ProductCategoryChart();
            ProductCategoriesName = _chartQuery.ProductCategoriesName();
        }
    }
}
