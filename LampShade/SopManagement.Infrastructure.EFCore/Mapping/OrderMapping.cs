using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.OrderAgg;

namespace SopManagement.Infrastructure.EFCore.Mapping
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IssueTrackingNo).HasMaxLength(8);

            builder.OwnsMany(x => x.Items, NavigationBuilder =>
            {
                NavigationBuilder.ToTable("OrderItem");
                NavigationBuilder.HasKey(x => x.Id);
                NavigationBuilder.WithOwner(x => x.Order).HasForeignKey(x => x.OrderId);
            });
        }
    }
}
