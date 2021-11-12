using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "ListProducts"),
                        new PermissionDto(ShopPermissions.SearchProducts, "SearchProducts"),
                        new PermissionDto(ShopPermissions.EditProduct, "EditProducts"),
                        new PermissionDto(ShopPermissions.CreateProduct, "CreateProducts")
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProductCategories, "ListProductCategories"),
                        new PermissionDto(ShopPermissions.SearchProductCategories, "SearchProductCategories"),
                        new PermissionDto(ShopPermissions.EditProductCategory, "EditProductCategories"),
                        new PermissionDto(ShopPermissions.CreateProductCategory, "CreateProductCategories")
                    }
                },
                {
                    "Slide", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.CreateSlide, "CreateSlide"),
                        new PermissionDto(ShopPermissions.EditSlide, "EditSlide"),
                        new PermissionDto(ShopPermissions.ListSlide, "ListSlide"),
                        new PermissionDto(ShopPermissions.RemoveSlide, "RemoveSlide"),
                        new PermissionDto(ShopPermissions.RestoreSlide, "RestoreSlide")
                    }
                },
                {
                    "ProductPicture", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.CreateProductPicture, "CreateProductPicture"),
                        new PermissionDto(ShopPermissions.EditProductPicture, "EditProductPicture"),
                        new PermissionDto(ShopPermissions.ListProductPicture, "ListProductPicture"),
                        new PermissionDto(ShopPermissions.SearchProductPicture, "SearchProductPicture"),
                        new PermissionDto(ShopPermissions.RemoveProductPicture, "RemoveProductPicture"),
                        new PermissionDto(ShopPermissions.RestoreProductPicture, "RestoreProductPicture")
                    }
                }
            };
        }
    }
}
