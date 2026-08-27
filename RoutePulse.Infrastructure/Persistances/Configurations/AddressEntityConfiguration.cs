using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Infrastructure.Extensions;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Persistances.Configurations;

public class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
{
    public void Configure(EntityTypeBuilder<AddressEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.CustomerId)
            .ValueGeneratedNever()
            .IsRequired();

        builder
            .HasOne(x => x.Customer)
            .WithMany()
            .HasForeignKey(x => x.CustomerId);

        builder
            .HasIndex(x => new { x.AddressName, x.CustomerId }, "Unique_Address")
            .IsUnique(true);

        builder
            .Property(x => x.AddressName)
            .RequriedMaxLen(64);

        builder
            .Property(x => x.Country)
            .RequriedMaxLen(64);

        builder
            .Property(x => x.City)
            .RequriedMaxLen();

        builder
            .Property(x => x.PostalCode)
            .RequriedMaxLen(12);

        builder
            .Property(x => x.Floor)
            .RequriedMaxLen(8);

        builder
            .Property(x => x.Flat)
            .RequriedMaxLen(8);

        builder
            .Property(x => x.AddressDetail)
            .RequriedMaxLen();

        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValue("getdate()")
            .ValueGeneratedOnAdd();
    }
}
