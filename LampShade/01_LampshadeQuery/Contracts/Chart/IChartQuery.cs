using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Chart
{
    public interface IChartQuery
    {
        int GetCurrentUsersCount();
        double TotalSales();
        int NewOrdersCount();
        int ArticleCount();
        Chart PaymentMethodChart();
        Chart SellChart();
        Chart ProductCategoryChart();
        List<string> ProductCategoriesName();
    }
}
