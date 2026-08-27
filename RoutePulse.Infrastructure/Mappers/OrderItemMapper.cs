using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class OrderItemMapper
{
    public static OrderItemEntity ToEntity(this OrderItem model)
    => new()
    {
        Id = model.Id,
        OrderId = model.OrderId,
        ProductId = model.ProductId,
        Quantity = model.Quantity,
        UnitPrice = model.UnitPrice
    };
}
