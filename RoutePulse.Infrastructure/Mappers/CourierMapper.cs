using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class CourierMapper
{
    public static CourierEntity ToEntity(this Courier model)
    => new()
    {
        Id = model.Id,
        FullName = model.FullName,
        CreatedAt = model.CreatedAt
    };
}
