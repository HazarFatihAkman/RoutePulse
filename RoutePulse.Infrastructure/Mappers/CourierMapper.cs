using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class CourierMapper
{
    public static CourierEntity toEntity(this Courier model)
    => new()
    {
        Id = model.Id,
        FullName = model.FullName,
        CreatedAt = model.CreatedAt
    };
}
