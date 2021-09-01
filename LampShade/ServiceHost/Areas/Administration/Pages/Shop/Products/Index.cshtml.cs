using System.Collections.Generic;
using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public SelectList ProductCategories;
        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Products;

        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _categoryApplication;


        public IndexModel(IProductApplication productApplication, IProductCategoryApplication categoryApplication)
        {
            _productApplication = productApplication;
            _categoryApplication = categoryApplication;
        }

        public void OnGet(ProductSearchModel searchModel)
        {
            Products = _productApplication.Search(searchModel);
            ProductCategories = new SelectList(_categoryApplication.GetProductCategories(), "Id", "Name");
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct { Categories = _categoryApplication.GetProductCategories() };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateProduct command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;
            var result = _productApplication.Create(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productApplication.GetDetails(id);
            product.Categories = _categoryApplication.GetProductCategories();
            return Partial("Edit", product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _productApplication.Edit(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

    }
}
