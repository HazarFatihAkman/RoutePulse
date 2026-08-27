using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class OrderStatusHistoryMapper
{
    public static OrderStatusHistoryEntity ToEntity(this OrderStatusHistory model)
    => new()
    {
        Id = model.Id,
        OrderId = model.OrderId,
        CourierId = model.CourierId,
        Status = model.Status,
        CreatedAt = model.CreatedAt
    };
}
