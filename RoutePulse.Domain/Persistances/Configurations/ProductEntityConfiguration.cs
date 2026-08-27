using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoutePulse.Domain.Extentions;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Persistances.Configurations;

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
            .Property(x => x.CreatedAt)
            .HasDefaultValue("getdate()")
            .ValueGeneratedOnAdd();

        builder
            .ToTable("Products", table =>
            {
                table.HasCheckConstraint(
                    "CK_Produtcs_Price",
                    "[Price] => 0"
                );
            });
    }
}
