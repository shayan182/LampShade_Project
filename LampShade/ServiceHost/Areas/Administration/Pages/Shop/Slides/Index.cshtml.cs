﻿using System.Collections.Generic;
using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;

namespace ServiceHost.Areas.Administration.Pages.Shop.Slides
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<SlideViewModel> Slides;

        private readonly ISlideApplication _slideApplication;

        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }

        public void OnGet()
        {
            Slides = _slideApplication.GetList();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateSlide();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateSlide command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;
            
            var result = _slideApplication.Create(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slides = _slideApplication.GetDetails(id);
            return Partial("Edit", slides);
        }

        public JsonResult OnPostEdit(EditSlide command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _slideApplication.Edit(command);
            Message = ValidationMessages.Success;
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {

            var result = _slideApplication.Remove(id);
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
            var result = _slideApplication.Restore(id);
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
