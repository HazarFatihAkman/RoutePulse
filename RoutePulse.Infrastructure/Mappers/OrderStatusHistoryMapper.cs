using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class OrderStatusHistoryMapper
{
    public static OrderStatusHistoryEntity ToEntity(this OrderStatusHistory model)
    => new()
    {
        Id = model.Id,
        OrderId = model.OrderId,
        AssignedCourierId = model.AssignedCourierId,
        Status = model.Status,
        CreatedAt = model.CreatedAt
    };
}
