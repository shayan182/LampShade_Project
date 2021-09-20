using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleCategoryModel : PageModel
    {
        public ArticleCategoryQueryModel ArticleCategory;
        public List<ArticleCategoryQueryModel> ArticleCategories;
        public List<ArticleQueryModel> LatestArticles;
        private readonly IArticleQuery _article;
        private readonly IArticleCategoryQuery _articleCategory;
        public ArticleCategoryModel(IArticleCategoryQuery articleCategory, IArticleQuery article)
        {
            _articleCategory = articleCategory;
            _article = article;
        }

        public void OnGet(string id)
        {
            ArticleCategory = _articleCategory.GetArticleCategory(id);
            ArticleCategories = _articleCategory.GetArticleCategories();
            LatestArticles = _article.LatestArticles();
        }
    }
}