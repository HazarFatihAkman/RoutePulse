using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class ProductMapper
{
    public static ProductEntity ToEntity(this Product model)
    => new()
    {
        Id = model.Id,
        Name = model.Name,
        Price = model.Price,
        PreparingTimeMin = model.PreparingTimeMin,
        CreatedAt = model.CreatedAt
    };
}
