using System.Collections.Generic;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Infrastructure.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Account
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public SelectList Roles;
        public AccountSearchModel SearchModel;
        public List<AccountViewModel> Accounts;
        private readonly IAccountApplication _accountApplication;
        private readonly IRoleApplication _roleApplication;
        public IndexModel(IAccountApplication accountApplication, IRoleApplication roleApplication)
        {
            _accountApplication = accountApplication;
            _roleApplication = roleApplication;
        }

        [NeedsPermission(AccountPermissions.ListAccount)]
        public void OnGet(AccountSearchModel searchModel)
        {
            Roles = new SelectList(_roleApplication.List(), "Id", "Name");
            Accounts = _accountApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new RegisterAccount()
            {
                Roles = _roleApplication.List()
            };
            return Partial("./Create", command);
        }

        [NeedsPermission(AccountPermissions.CreateAccount)]
        public JsonResult OnPostCreate(RegisterAccount command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;
            var result = _accountApplication.Register(command);
            Message = result.Message;
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var account = _accountApplication.GetDetails(id);
            account.Roles = _roleApplication.List();
            return Partial("Edit", account);
        }

        [NeedsPermission(AccountPermissions.EditAccount)]
        public JsonResult OnPostEdit(EditAccount command)
        {
            var result = _accountApplication.Edit(command);
            Message = result.Message;
            return new JsonResult(result);
        }

        public IActionResult OnGetChangePassword(long id)
        {
            var command = new ChangePassword {Id = id};
            return Partial("ChangePassword", command);
        }

        [NeedsPermission(AccountPermissions.ChangePasswordAccount)]
        public JsonResult OnPostChangePassword(ChangePassword command)
        {
            if (!ModelState.IsValid)
                Message = ValidationMessages.Error;

            var result = _accountApplication.ChangePassword(command);
            Message = result.Message;
            return new JsonResult(result);
        }

    }
}
