using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DiscountManagement.Domain.CustomerDiscountAgg;

namespace CustomerDiscount.Infrastructure.EFCore.Mapping
{
    public class CustomerDiscountMapping : IEntityTypeConfiguration<DiscountManagement.Domain.CustomerDiscountAgg.CustomerDiscount>
    {
        public void Configure(EntityTypeBuilder<DiscountManagement.Domain.CustomerDiscountAgg.CustomerDiscount> builder)
        {
            builder.ToTable("CustomerDiscounts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Reason).HasMaxLength(500);
        }
    }
}
