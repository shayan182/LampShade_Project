using System.Collections.Generic;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using InventoryManagement.Application.Contract.Inventory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administration.Pages.Inventory
{
    [Authorize(Roles = Roles.Administrator)]
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public InventorySearchModel SearchModel;
        public List<InventoryViewModel> Inventory;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly IInventoryApplication _inventoryApplication;

        public IndexModel(IProductApplication productApplication, IInventoryApplication inventoryApplication)
        {
            _productApplication = productApplication;
            _inventoryApplication = inventoryApplication;
        }

        public void OnGet(InventorySearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            Inventory = _inventoryApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateInventory()
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateInventory command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _inventoryApplication.Create(command);
            Message = result.Message;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var customerDiscount = _inventoryApplication.GetDetails(id);
            customerDiscount.Products = _productApplication.GetProducts();
            return Partial("Edit", customerDiscount);
        }

        public JsonResult OnPostEdit(EditInventory command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _inventoryApplication.Edit(command);
            Message = result.Message;
            return new JsonResult(result);
        }
        public IActionResult OnGetIncrease(long id)
        {
            var command = new IncreaseInventory()
            {
                InventoryId = id
            };
            return Partial("Increase", command);
        }

        public JsonResult OnPostIncrease(IncreaseInventory command)
        {
            var result = _inventoryApplication.Increase(command);
            
            return new JsonResult(result);
        }
        public IActionResult OnGetReduce(long id)
        {
            var command = new ReduceInventory()
            {
                InventoryId = id
            };
            return Partial("Reduce", command);
        }

        public JsonResult OnPostReduce(ReduceInventory command)
        {
            var result = _inventoryApplication.Reduce(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetLog(long id)
        {
            var log = _inventoryApplication.GetOperationLog(id);
            return Partial("./OperationLog", log);
        }
      
    }
}
