using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class OrderItemMapper
{
    public static OrderItemEntity toEntity(this OrderItem model)
    => new()
    {
        Id = model.Id,
        OrderId = model.OrderId,
        ProductId = model.ProductId,
        Quantity = model.Quantity,
        UnitPrice = model.UnitPrice
    };
}
