using System.Collections.Generic;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.Orders
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }  
        public OrderSearchModel SearchModel;
        public SelectList Account;
        public List<OrderViewModel> Orders;

        private readonly IOrderApplication _orderApplication;
        private readonly IAccountApplication _accountApplication;

        public IndexModel(IOrderApplication orderApplication, IAccountApplication accountApplication)
        {
            _orderApplication = orderApplication;
            _accountApplication = accountApplication;
        }

        [NeedsPermission(ShopPermissions.ListOrder)]
        public void OnGet(OrderSearchModel searchModel)
        {
            Orders = _orderApplication.Search(searchModel);
            Account = new SelectList(_accountApplication.GetAccounts(),"Id","Fullname");
        }
        
    }
}
