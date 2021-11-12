using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace AccountManagement.Infrastructure.Configuration.Permissions
{
    public class AccountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Account", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListAccount, "ListAccount"),
                        new PermissionDto(AccountPermissions.SearchAccount, "SearchAccount"),
                        new PermissionDto(AccountPermissions.EditAccount, "EditAccount"),
                        new PermissionDto(AccountPermissions.CreateAccount, "CreateAccount"),
                        new PermissionDto(AccountPermissions.ChangePasswordAccount, "ChangePasswordAccount")
                    }
                },
                {
                    "Role", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListRole, "ListRole"),
                        new PermissionDto(AccountPermissions.EditRole, "EditRole"),
                        new PermissionDto(AccountPermissions.CreateRole, "CreateRole")
                    }
                }
            };
        }
    }
}
