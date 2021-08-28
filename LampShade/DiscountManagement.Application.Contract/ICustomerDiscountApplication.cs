using System.Collections.Generic;
using _0_Framework.Application;

namespace DiscountManagement.Application.Contract
{
    public interface ICustomerDiscountApplication
    {
        OperationResult Define(DefineCustomerDiscount command);
        OperationResult Edit(EditCustomerDiscount command);
        EditCustomerDiscount GetDetails(long id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
        
    }
}
