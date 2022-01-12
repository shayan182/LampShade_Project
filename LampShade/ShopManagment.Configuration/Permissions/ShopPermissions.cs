namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissions
    {
        //Product
        public const int ListProducts = 10;
        public const int SearchProducts = 11;
        public const int CreateProduct = 12;
        public const int EditProduct = 13;

        //ProductCategory
        public const int ListProductCategories = 20;
        public const int SearchProductCategories = 21;
        public const int CreateProductCategory = 22;
        public const int EditProductCategory = 23;

        //Slide
        public const int ListSlide = 100;
        public const int CreateSlide = 101;
        public const int EditSlide = 102;
        public const int RemoveSlide = 103;
        public const int RestoreSlide = 104;

        //ProductPicture
        public const int ListProductPicture = 110;
        public const int SearchProductPicture =111;
        public const int CreateProductPicture = 112;
        public const int EditProductPicture = 113;
        public const int RemoveProductPicture = 114;
        public const int RestoreProductPicture = 115;

        //Orders
        public const int ListOrder = 130;
        public const int SearchOrder = 131;
        public const int ConfirmOrder = 132;
        public const int CancelOrder = 133;
        public const int OrderItems = 134;
    }
}
