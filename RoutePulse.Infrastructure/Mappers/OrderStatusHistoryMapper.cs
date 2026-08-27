using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class OrderStatusHistoryMapper
{
    public static OrderStatusHistoryEntity toEntity(this OrderStatusHistory model)
    => new()
    {
        Id = model.Id,
        OrderId = model.OrderId,
        AssignedCourierId = model.AssignedCourierId,
        Status = model.Status,
        CreatedAt = model.CreatedAt
    };
}
