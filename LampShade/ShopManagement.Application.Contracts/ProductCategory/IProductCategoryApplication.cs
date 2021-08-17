using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategory command);
        OperationResult Edit(EditProductCategory command);
        List<ProductCategoryViewModes> Search(ProductCategorySearchModel searchModel);
       
        EditProductCategory GetDetails(long id);

    }
}
