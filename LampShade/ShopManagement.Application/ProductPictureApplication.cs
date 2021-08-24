using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Domain.ProductPictureAgg;

namespace ShopManagement.Application
{
    public class ProductPictureApplication : IProductPictureApplication
    {
        private readonly IProductPictureRepository _pictureRepository;

        public ProductPictureApplication(IProductPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }

        public OperationResult Create(CreateProductPicture command)
        {
            var operation = new OperationResult();

            if (_pictureRepository.Exists(x => x.Picture == command.Picture && x.ProductId == command.ProductId))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var product = new ProductPicture(command.ProductId, command.Picture, command.PictureAlt,
                command.PictureTitle);
            _pictureRepository.Create(product);
            _pictureRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProductPicture command)
        {
            var operation = new OperationResult();
            var productPicture = _pictureRepository.Get(command.Id);

            if (productPicture == null)
                    return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_pictureRepository.Exists(x =>
                x.Picture == command.Picture && x.ProductId == command.ProductId && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            productPicture.Edit(command.ProductId,command.Picture,command.PictureAlt,command.PictureTitle);
            _pictureRepository.SaveChanges();
            return operation.Succeeded();
        }
        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var productPicture = _pictureRepository.Get(id);

            if (productPicture == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            productPicture.Remove();
            _pictureRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var productPicture = _pictureRepository.Get(id);

            if (productPicture == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            productPicture.Restore();
            _pictureRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditProductPicture GetDetails(long id)
        {
            return _pictureRepository.GetDetails(id);
        }

        public List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel)
        {
            return _pictureRepository.Search(searchModel);
        }
    }
}
