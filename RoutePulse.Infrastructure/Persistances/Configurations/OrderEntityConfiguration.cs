using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Domain.Extensions;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Persistances.Configurations;

public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
{
    public void Configure(EntityTypeBuilder<OrderEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.CustomerId)
            .ValueGeneratedNever()
            .IsRequired();

        builder
            .Property(x => x.AddressId)
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
            .Property(x => x.PaymentMethod)
            .IsRequired();

        builder
            .Property(x => x.PaymentStatus)
            .HasDefaultValue(0)
            .IsRequired();

        builder
            .HasOne(x => x.Customer)
            .WithMany()
            .HasForeignKey(x => x.CustomerId);

        builder
            .HasOne(x => x.Address)
            .WithMany()
            .HasForeignKey(x => x.AddressId);

        builder
            .HasOne(x => x.AssignedCourier)
            .WithMany()
            .HasForeignKey(x => x.AssignedCourierId);

        builder
            .HasMany(x => x.Items)
            .WithOne(x => x.Order)
            .HasForeignKey(x => x.OrderId);

        builder
            .ToTable("Orders", table =>
            {
                table.HasCheckConstraint(
                    "CK_Orders_TotalAmount",
                    "[TotalAmount] >= 0"
                );
            });
    }
}