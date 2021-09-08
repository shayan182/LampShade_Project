using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Product;
using _01_LampshadeQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public List<ProductQueryModel> Products { get; set; }
        private readonly IProductQuery _productQuery;

        public SearchModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public void OnGet(string value)
        {
            Value = value;
            Products= _productQuery.Search(value);
        }
    }
}
