using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using System.Collections.Generic;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contract;
using DiscountManagement.Application.Contract.CustomerDiscount;
using DiscountManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Discounts.CustomerDiscounts
{
    //[Authorize(Roles = Roles.Administator)]
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public CustomerDiscountSearchModel SearchModel;
        public List<CustomerDiscountViewModel> CustomerDiscounts;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly ICustomerDiscountApplication _customerDiscountApplication;

        public IndexModel(IProductApplication productApplication, ICustomerDiscountApplication customerDiscountApplication)
        {
            _productApplication = productApplication;
            _customerDiscountApplication = customerDiscountApplication;
        }

        [NeedsPermission(DiscountPermissions.ListCustomerDiscount)]
        public void OnGet(CustomerDiscountSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            CustomerDiscounts = _customerDiscountApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new DefineCustomerDiscount
            {
                Products =  _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        [NeedsPermission(DiscountPermissions.CreateCustomerDiscount)]
        public JsonResult OnPostCreate(DefineCustomerDiscount command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _customerDiscountApplication.Define(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var customerDiscount = _customerDiscountApplication.GetDetails(id);
            customerDiscount.Products = _productApplication.GetProducts();
            return Partial("Edit", customerDiscount);
        }

        [NeedsPermission(DiscountPermissions.EditCustomerDiscount)]
        public JsonResult OnPostEdit(EditCustomerDiscount command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _customerDiscountApplication.Edit(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }
    }
}
