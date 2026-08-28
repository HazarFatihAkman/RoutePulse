using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Domain.Enums;
using RoutePulse.Infrastructure.Extensions;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Persistances.Configurations;

public class OrderStatusHistoryEntityConfiguration : IEntityTypeConfiguration<OrderStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<OrderStatusHistoryEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.OrderId)
            .ValueGeneratedNever()
            .IsRequired();

        builder
            .Property(x => x.AssignedCourierId)
            .ValueGeneratedNever()
            .IsRequired(false);

        builder
            .Property(x => x.Status)
            .HasDefaultValue(OrderStatus.Created)
            .IsRequired();

        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd();

        builder
            .HasOne(x => x.Order)
            .WithMany()
            .HasForeignKey(x => x.OrderId);

        builder
            .HasOne(x => x.AssignedCourier)
            .WithMany()
            .HasForeignKey(x => x.AssignedCourierId);
    }
}