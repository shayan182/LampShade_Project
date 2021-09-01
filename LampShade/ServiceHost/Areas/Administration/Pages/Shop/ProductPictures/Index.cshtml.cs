using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductPicture;
using System.Collections.Generic;
using _0_Framework.Application;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductPictures
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public ProductPictureSearchModel SearchModel;
        public List<ProductPictureViewModel> ProductPictures;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly IProductPictureApplication _productPictureApplication;
        public IndexModel(IProductApplication productApplication, IProductPictureApplication productPictureApplication)
        {
            _productApplication = productApplication;
            _productPictureApplication = productPictureApplication;
        }

        public void OnGet(ProductPictureSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            ProductPictures = _productPictureApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductPicture
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProductPicture command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;
            
            var result = _productPictureApplication.Create(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productPicture = _productPictureApplication.GetDetails(id);
            productPicture.Products = _productApplication.GetProducts();
            return Partial("Edit", productPicture);
        }

        public JsonResult OnPostEdit(EditProductPicture command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;
            var result = _productPictureApplication.Edit(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _productPictureApplication.Remove(id);
            if (result.IsSuccedded)
            {
                Message = result.Message;
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _productPictureApplication.Restore(id);
            if (result.IsSuccedded)
            {
                Message = result.Message;
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
