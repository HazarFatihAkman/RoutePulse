using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Domain.Extensions;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Persistances.Configurations;

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
            .HasDefaultValue(0)
            .IsRequired();

        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValue("getdate()")
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