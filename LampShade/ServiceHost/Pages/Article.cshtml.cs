using System.Collections.Generic;
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.ArticleCategory;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleModel : PageModel
    {
        [TempData] public string Message { get; set; }
        public List<ArticleCategoryQueryModel> ArticleCategory;
        public ArticleQueryModel Article;
        public List<ArticleQueryModel> LatestArticles;
        private readonly IArticleCategoryQuery _articleCategoryQuery;
        private readonly IArticleQuery _articleQuery;
        private readonly ICommentApplication _commentApplication;
        public ArticleModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery, ICommentApplication commentApplication)
        {
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
            _commentApplication = commentApplication;
        }
        public void OnGet(string id)
        {
            Article = _articleQuery.GetArticleDetails(id);
            LatestArticles = _articleQuery.LatestArticles();
            ArticleCategory = _articleCategoryQuery.GetArticleCategories();
        }
        public IActionResult OnPost(AddComment command, string articleSlug)
        {
            command.Type = CommentType.Article;
            if (!ModelState.IsValid)
            {
                Message = ValidationMessages.Error;
                return RedirectToPage("/Article", new { Id = articleSlug });
            }
            var result = _commentApplication.Add(command);
            Message = result.Message;
            return RedirectToPage("/Article", new { Id = articleSlug });
        }
    }
}
