using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Infrastructure.Extensions;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Persistances.Configurations;

public class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.FullName)
            .RequiredMaxLen();

        builder
            .Property(x => x.Email)
            .RequiredMaxLen();

        builder
            .Property(x => x.PhoneNumber)
            .RequiredMaxLen();

        builder
            .HasMany(x => x.Orders)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);

        builder
            .HasMany(x => x.Addresses)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId);
    }
}
