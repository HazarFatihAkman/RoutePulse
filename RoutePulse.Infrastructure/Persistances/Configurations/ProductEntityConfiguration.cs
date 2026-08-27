using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Infrastructure.Extensions;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Persistances.Configurations;

public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.PrimaryGUID(x => x.Id);

        builder
            .Property(x => x.Name)
            .RequriedMaxLen();

        builder
            .Property(x => x.Price)
            .HasDefaultValue(0)
            .IsRequired();

        builder
            .Property(x => x.PreparingTimeMin)
            .HasDefaultValue(0)
            .IsRequired();

        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValue("getdate()")
            .ValueGeneratedOnAdd();

        builder
            .ToTable("Products", table =>
            {
                table.HasCheckConstraint(
                    "CK_Produtcs_Price",
                    "[Price] >= 0"
                );

                table.HasCheckConstraint(
                    "CK_Produtcs_PreparingTimeMin",
                    "[PreparingTimeMin] >= 0"
                );
            });
    }
}
