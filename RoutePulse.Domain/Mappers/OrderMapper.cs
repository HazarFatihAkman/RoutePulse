using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class OrderMapper
{
    public static OrderEntity toEntity(this Order model)
    => new()
    {
        Id = model.Id,
        CustomerId = model.CustomerId,
        AddressId = model.AddressId,
        Status = model.Status,
        PaymentMethod = model.PaymentMethod,
        PaymentStatus = model.PaymentStatus
    };
}
