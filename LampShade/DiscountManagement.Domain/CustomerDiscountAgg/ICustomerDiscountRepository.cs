﻿using System.Collections.Generic;
using _0_Framework.Domain;
using DiscountManagement.Application.Contract;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public interface ICustomerDiscountRepository : IRepository<long , CustomerDiscount>
    {
        EditCustomerDiscount GetDetails(long id);
        List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel);
    }
}
