﻿using System.Collections.Generic;
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
            {
                Message = "عملیات با شکست مواجه شد!!";

            }
            var result = _productApplication.Create(command);
            Message = "عملیات با موفقیت انجام شد!!";
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
            {
                Message = "عملیات با شکست مواجه شد!!";

            }

            var result = _productApplication.Edit(command);
            Message = "عملیات با موفقیت انجام شد!!";
            return new JsonResult(result);
        }

        public IActionResult OnGetNotInStock(long id)
        {
            var result = _productApplication.NotInStock(id);
            if (result.IsSuccedded)
            {
                Message = result.Message;
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetIsInStock(long id)
        {
            var result = _productApplication.InStock(id);
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