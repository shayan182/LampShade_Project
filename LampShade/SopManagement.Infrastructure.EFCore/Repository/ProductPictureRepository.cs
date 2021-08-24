﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Domain.ProductPictureAgg;

namespace SopManagement.Infrastructure.EFCore.Repository
{
    public class ProductPictureRepository : RepositoryBase<long, ProductPicture>, IProductPictureRepository
    {
        private readonly ShopContext _context;

        public ProductPictureRepository(ShopContext context) : base(context)
        {
            _context = context;
        }


        public EditProductPicture GetDetails(long id)
        {
            return _context.ProductPictures.Select(x => new EditProductPicture
            {
                Id = x.Id,
                PictureAlt = x.PictureAlt,
                Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                ProductId = x.ProductId
            })
                .FirstOrDefault(x => x.Id == id);

        }

        public List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel)
        {
            var query = _context.ProductPictures.Include(x => x.Product)
                .Select(x => new ProductPictureViewModel
                {
                    Id = x.Id,
                    Product = x.Product.Name,
                    CreationDate = x.CreationDate.ToString(),
                    Picture = x.Picture,
                    ProductId =x.ProductId,
                    IsRemoved = x.IsRemoved
                });
            if (searchModel.ProductId != 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            return query.OrderByDescending(x => x.Id).ToList();

        }
    }
}
