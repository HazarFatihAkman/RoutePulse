using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RoutePulse.Infrastructure.Extensions;

public static class EntityTypeBuilderExtensions
{
    public static PropertyBuilder<T> RequriedMaxLen<T>(
        this PropertyBuilder<T> property,
        int maxLen = 256
    ) => property.HasMaxLength(maxLen).IsRequired();

    public static void PrimaryGUID<T>(
        this EntityTypeBuilder<T> builder,
        Expression<Func<T, Guid>> expression
    ) where T : class
    {
        var keyExpression = Expression.Lambda<Func<T, object?>>(
            Expression.Convert(expression.Body, typeof(object)),
            expression.Parameters
        );

        builder
            .HasKey(keyExpression)
            .IsClustered(true);

        builder
            .Property(expression)
            .ValueGeneratedOnAdd()
            .IsRequired();
    }
}
