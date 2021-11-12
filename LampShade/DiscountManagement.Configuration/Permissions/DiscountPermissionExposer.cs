using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace DiscountManagement.Configuration.Permissions
{
    public class DiscountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "CustomerDiscount", new List<PermissionDto>
                    {
                       new PermissionDto(DiscountPermissions.CreateCustomerDiscount , "CreateCustomerDiscount"), 
                       new PermissionDto(DiscountPermissions.EditCustomerDiscount , "EditCustomerDiscount"), 
                       new PermissionDto(DiscountPermissions.ListCustomerDiscount , "ListCustomerDiscount"), 
                       new PermissionDto(DiscountPermissions.SearchCustomerDiscount , "SearchCustomerDiscount"),
                    }
                },
                {
                    "ColleagueDiscount", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.CreateColleagueDiscount , "CreateColleagueDiscount"),
                        new PermissionDto(DiscountPermissions.EditColleagueDiscount , "EditColleagueDiscount"),
                        new PermissionDto(DiscountPermissions.ListColleagueDiscount , "ListColleagueDiscount"),
                        new PermissionDto(DiscountPermissions.SearchColleagueDiscount , "SearchColleagueDiscount"),
                        new PermissionDto(DiscountPermissions.RemoveColleagueDiscount , "RemoveColleagueDiscount"),
                        new PermissionDto(DiscountPermissions.RestoreColleagueDiscount , "RestoreColleagueDiscount"),
                    }
                }
            };
        }
    }
}
