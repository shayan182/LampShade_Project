using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            {
                Message = "عملیات با شکست مواجه شد!!";

            }
            var result = _categoryApplication.Create(command);
            Message = "عملیات با موفقیت انجام شد!!";
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
            {
                Message = "عملیات با شکست مواجه شد!!";

            }

            var result = _categoryApplication.Edit(command);
            Message = "عملیات با موفقیت انجام شد!!";
            return new JsonResult(result);
        }
    }
}
