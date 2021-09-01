using System.Collections.Generic;
using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }  
        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategories;
        private readonly IProductCategoryApplication _categoryApplication;

        public IndexModel(IProductCategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }

        public void OnGet(ProductCategorySearchModel searchModel)
        {
            ProductCategories = _categoryApplication.Search(searchModel);

        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProductCategory());
        }
        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _categoryApplication.Create(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _categoryApplication.GetDetails(id);
            return Partial("Edit", productCategory);
        }

        public JsonResult OnPostEdit(EditProductCategory command)
        {
            if (!ModelState.IsValid )
                Message = ValidationMessages.Error;

            var result = _categoryApplication.Edit(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }
    }
}
