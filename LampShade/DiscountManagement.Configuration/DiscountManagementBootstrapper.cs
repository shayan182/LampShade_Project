using System;
using CustomerDiscount.Infrastructure.EFCore;
using CustomerDiscount.Infrastructure.EFCore.Repository;
using DiscountManagement.Application;
using DiscountManagement.Application.Contract;
using DiscountManagement.Domain.CustomerDiscountAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DiscountManagement.Configuration
{
    public class DiscountManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICustomerDiscountApplication, CustomerDiscountApplication>();
            services.AddTransient<ICustomerDiscountRepository, CustomerDiscountRepository>();

            services.AddDbContext<DiscountContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
