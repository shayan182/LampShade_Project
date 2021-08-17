using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _categoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_categoryRepository.Exists(x => x.Name == command.Name))
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد.لطفا مجدد تلاش بفرمایید");
            var slug = command.Slug.Slugify();
            var productCategory = new ProductCategory(command.Name, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug);

            _categoryRepository.Create(productCategory);
            _categoryRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _categoryRepository.Get(command.Id);
            if (productCategory == null)
                return operation.Failed("رکوردی با اطلاعات درخواست شده یافت نشد . لطفا مجدد تلاش بفرمایید");

            if (_categoryRepository.Exists(x => x.Id != command.Id && x.Name == command.Name))
                return operation.Failed("رکوردی با اطلاعات درخواست شده یافت نشد . لطفا مجدد تلاش بفرمایید");

            var slug = command.Slug.Slugify();
            productCategory.Edit(command.Name, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle
                , command.Keywords, command.MetaDescription, slug);
            _categoryRepository.SaveChanges();
            return operation.Succeeded();
        }

        public List<ProductCategoryViewModes> Search(ProductCategorySearchModel searchModel)
        {
            return _categoryRepository.Search(searchModel);
        }

        public EditProductCategory GetDetails(long id)
        {
            return _categoryRepository.GetDetails(id);
        }
    }
}
