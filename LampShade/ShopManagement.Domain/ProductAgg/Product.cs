﻿using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;

namespace ShopManagement.Domain.ProductAgg
{
    public class Product : EntityBase
    {

        public string Name { get; private set; }
        public double UnitPrice { get; private set; }
        public string Code { get; private set; }
        public bool IsInStock { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public long CategoryId { get; private set; }
        public ProductCategory Category { get; private set; }
        public List<ProductPicture> ProductPictures { get; set; }

        public Product(string name, double unitPrice, string code, string shortDescription,
            string description, string picture, string pictureAlt, string pictureTitle,
            string slug, string keywords, string metaDescription, long categoryId)
        {
            Name = name;
            UnitPrice = unitPrice;
            Code = code;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
            IsInStock = true;
        }
         public void Edit(string name, double unitPrice, string code, string shortDescription,
            string description, string picture, string pictureAlt, string pictureTitle,
            string slug, string keywords, string metaDescription, long categoryId)
        {
            Name = name;
            UnitPrice = unitPrice;
            Code = code;
            ShortDescription = shortDescription;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CategoryId = categoryId;
        }

         public void InStock()
         {
             IsInStock = true;
         }

         public void NotInStock()
         {
             IsInStock = false;

        }
    }
}
