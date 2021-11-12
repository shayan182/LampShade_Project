using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace BlogManagement.Infrastructure.Configuration.Permissions
{
    public class BlogPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Article", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListArticle, "ListArticle"),
                        new PermissionDto(BlogPermissions.SearchArticle, "SearchArticle"),
                        new PermissionDto(BlogPermissions.EditArticle, "EditArticle"),
                        new PermissionDto(BlogPermissions.CreateArticle, "CreateArticle")
                    }
                },
                {
                    "ArticleCategory", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListArticleCategory, "ListArticleCategory"),
                        new PermissionDto(BlogPermissions.EditArticleCategory, "EditArticleCategory"),
                        new PermissionDto(BlogPermissions.SearchArticleCategory, "SearchArticleCategory"),
                        new PermissionDto(BlogPermissions.CreateArticleCategory, "CreateArticleCategory")
                    }
                },
            };
        }
    }
}
