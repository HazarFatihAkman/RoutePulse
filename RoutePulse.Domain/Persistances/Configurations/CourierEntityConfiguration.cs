using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Domain.Extentions;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Persistances.Configurations;

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
