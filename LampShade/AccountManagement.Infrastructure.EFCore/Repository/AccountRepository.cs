using System.Collections.Generic;
using System.Linq;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountContext _context;
        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public EditAccount GetDetails(long id)
        {
            return _context.Accounts
                .Select(x => new EditAccount
                {
                    Id = x.Id,
                    Fullname = x.Fullname,
                    Mobile = x.Mobile,
                    Password = x.Password,
                    Username = x.Username
                })
                .FirstOrDefault(x => x.Id == id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            var query = _context.Accounts
                .Select(x => new AccountViewModel
                {
                    Id = x.Id,
                    Fullname = x.Fullname,
                    Mobile = x.Mobile,
                    ProfilePhoto = x.ProfilePhoto,
                    RuleId = x.RuleId,
                    Rule = "مدیر سیستم",
                    Username = x.Username
                });
            if (!string.IsNullOrWhiteSpace(searchModel.Fullname))
                query = query.Where(x => x.Fullname.Contains(searchModel.Fullname));

            if (!string.IsNullOrWhiteSpace(searchModel.Username))
                query = query.Where(x => x.Fullname.Contains(searchModel.Username));

            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
                query = query.Where(x => x.Fullname.Contains(searchModel.Mobile));

            if (searchModel.RuleId > 0)
                query = query.Where(x => x.RuleId == searchModel.RuleId);

            return query.OrderByDescending(x => x.Id).ToList();
        }

    }
}
