using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Domain.Persistances.Entities;
using RoutePulse.Domain.Extentions;

namespace RoutePulse.Domain.Persistances.Configurations;

public class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.FullName)
            .RequriedMaxLen();

        builder
            .Property(x => x.Email)
            .RequriedMaxLen();

        builder
            .Property(x => x.PhoneNumber)
            .RequriedMaxLen();

        builder
            .HasMany(x => x.Orders)
            .WithOne()
            .HasForeignKey(x => x.Id);

        builder
            .HasMany(x => x.Addresses)
            .WithOne()
            .HasForeignKey(x => x.Id);
    }
}
