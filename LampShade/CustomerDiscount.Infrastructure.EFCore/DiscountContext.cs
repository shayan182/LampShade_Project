using CustomerDiscount.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;
using DiscountManagement.Domain.CustomerDiscountAgg;

namespace CustomerDiscount.Infrastructure.EFCore
{
    public class DiscountContext : DbContext
    {
        public DbSet<DiscountManagement.Domain.CustomerDiscountAgg.CustomerDiscount> CustomerDiscounts { get; set; }

        public DiscountContext(DbContextOptions<DiscountContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CustomerDiscountMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
