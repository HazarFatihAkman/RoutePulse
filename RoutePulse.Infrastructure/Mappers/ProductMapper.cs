using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class ProductMapper
{
    public static ProductEntity toEntity(this Product model)
    => new()
    {
        Id = model.Id,
        Name = model.Name,
        Price = model.Price,
        PreparingTime = model.PreparingTime,
        CreatedAt = model.CreatedAt
    };
}
