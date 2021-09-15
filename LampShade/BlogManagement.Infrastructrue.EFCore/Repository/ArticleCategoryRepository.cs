using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using BlogManagement.Application.Contract.ArticleCategory;
using BlogManagement.Domain.ArticleCategoryAgg;

namespace BlogManagement.Infrastructure.EFCore.Repository
{
    public class ArticleCategoryRepository : RepositoryBase<long , ArticleCategory> , IArticleCategoryRepository
    {
        private readonly BlogContext _context;

        public ArticleCategoryRepository(BlogContext context):base(context)
        {
            _context = context;
        }


        public EditArticleCategory GetDetails(long id)
        {
            return _context.ArticleCategories.Select(x => new EditArticleCategory()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Slug = x.Slug,
                Keywords = x.KeyWords,
                MetaDescription = x.MetaDescription,
                CanonicalAddress = x.CanonicalAddress,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShowOrder = x.ShowOrder
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel)
        {
            var query = _context.ArticleCategories
                .Select(x => new ArticleCategoryViewModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                    Picture = x.Picture,
                    ShowOrder = x.ShowOrder,
                    CreationDate = x.CreationDate.ToFarsi()
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            return query.OrderByDescending(x=>x.ShowOrder).ToList();
        }
    }
}
