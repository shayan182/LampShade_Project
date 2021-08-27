using _01_LampshadeQuery.Contracts.ProductCategory;
using _01_LampshadeQuery.Query;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuery _categoryQuery;

        public ProductCategoryViewComponent(IProductCategoryQuery categoryQuery)
        {
            _categoryQuery = categoryQuery;
        }


        public IViewComponentResult Invoke()
        {
            var productCategory = _categoryQuery.GetProductCategories();
            return View(productCategory);
        }
    }
}

