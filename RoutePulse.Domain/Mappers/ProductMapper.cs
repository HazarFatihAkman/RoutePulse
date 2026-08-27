using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class ProductMapper
{
    public static ProductEntity ToEntity(this Product model)
    => new()
    {
        Id = model.Id,
        Name = model.Name,
        Price = model.Price,
        CreatedAt = model.CreatedAt
    };
}
