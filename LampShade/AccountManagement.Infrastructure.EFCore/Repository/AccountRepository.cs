﻿using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountContext _context;
        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public Account GetBy(string username)
        {
           return _context.Accounts.FirstOrDefault(x => x.Username == username);
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
                .Include(x=>x.Role)
                .Select(x => new AccountViewModel
                {
                    Id = x.Id,
                    Fullname = x.Fullname,
                    Mobile = x.Mobile,
                    ProfilePhoto = x.ProfilePhoto,
                    RoleId = x.RoleId,
                    Role = x.Role.Name,
                    Username = x.Username,
                    CreationDate = x.CreationDate.ToFarsi()
                });
            if (!string.IsNullOrWhiteSpace(searchModel.Fullname))
                query = query.Where(x => x.Fullname.Contains(searchModel.Fullname));

            if (!string.IsNullOrWhiteSpace(searchModel.Username))
                query = query.Where(x => x.Fullname.Contains(searchModel.Username));

            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
                query = query.Where(x => x.Fullname.Contains(searchModel.Mobile));

            if (searchModel.RoleId > 0)
                query = query.Where(x => x.RoleId == searchModel.RoleId);

            return query.OrderByDescending(x => x.Id).ToList();
        }

    }
}
