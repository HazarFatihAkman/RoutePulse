using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Infrastructure.Extensions;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Persistances.Configurations;

public class CourierEntityConfiguration : IEntityTypeConfiguration<CourierEntity>
{
    public void Configure(EntityTypeBuilder<CourierEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.FullName)
            .RequiredMaxLen();

        builder
            .HasMany(x => x.Orders)
            .WithOne(x => x.AssignedCourier)
            .HasForeignKey(x => x.AssignedCourierId);

        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValueSql("GETDATE()")
            .ValueGeneratedOnAdd();

        builder
            .ComplexProperty(x => x.CurrentLocation);

        builder
            .Property(x => x.CurrentSpeed)
            .IsRequired(false);

        builder
            .Property(x => x.LastLocationUpdate)
            .IsRequired(false);
    }
}
