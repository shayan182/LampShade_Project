using System.Data;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Product;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        [TempData] public string Message { get; set; }
        public ProductQueryModel Product;
        private readonly IProductQuery _productQuery;
        private readonly ICommentApplication _commentApplication;

        public ProductModel(IProductQuery productQuery, ICommentApplication commentApplication)
        {
            _productQuery = productQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(string id)
        {
            Product = _productQuery.GetProductDetails(id);

        }
        public IActionResult OnPost(AddComment command , string productSlug)
        {
            command.Type = CommentType.Product;
            if (!ModelState.IsValid)
            {
                Message = ValidationMessages.Error;
                return RedirectToPage("/Product", new { Id = productSlug });
            }
            var result = _commentApplication.Add(command);
            return RedirectToPage("/Product" ,new { Id = productSlug});
        }
    }
}
