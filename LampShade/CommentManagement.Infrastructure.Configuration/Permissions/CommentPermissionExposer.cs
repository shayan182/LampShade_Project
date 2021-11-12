using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace CommentManagement.Infrastructure.Configuration.Permissions
{
    public class CommentPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Comment", new List<PermissionDto>
                    {
                        new PermissionDto(CommentPermissions.ListComment, "ListComment"),
                        new PermissionDto(CommentPermissions.SearchComment, "SearchComment"),
                        new PermissionDto(CommentPermissions.CancelComment, "CancelComment"),
                        new PermissionDto(CommentPermissions.ConfirmComment, "ConfirmComment")
                    }
                }
            };
        }
    }
}
