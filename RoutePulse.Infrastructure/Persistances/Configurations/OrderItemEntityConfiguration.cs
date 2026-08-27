using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Infrastructure.Extensions;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Persistances.Configurations;

public class OrderItemEntityConfiguration : IEntityTypeConfiguration<OrderItemEntity>
{
    public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.OrderId)
            .ValueGeneratedNever()
            .IsRequired();

        builder
            .Property(x => x.ProductId)
            .ValueGeneratedNever()
            .IsRequired();

        builder
            .Property(x => x.Quantity)
            .HasDefaultValue(1)
            .IsRequired();

        builder
            .ToTable("OrderItems", table =>
            {
                table.HasCheckConstraint(
                    "CK_OrderItems_Quantity",
                    "[Quantity] >= 1"
                );

                table.HasCheckConstraint(
                    "CK_OrderItems_UnitPrice",
                    "[UnitPrice] >= 0"
                );
            });

        builder
            .Property(x => x.UnitPrice)
            .HasDefaultValue(0)
            .HasPrecision(18, 2)
            .IsRequired();

    }
}
