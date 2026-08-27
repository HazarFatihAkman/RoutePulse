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
            .RequriedMaxLen();

        builder
            .HasOne(x => x.Orders)
            .WithMany()
            .HasForeignKey(x => x.Id);

        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValue("getdate()")
            .ValueGeneratedOnAdd();
    }
}
