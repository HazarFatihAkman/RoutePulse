using RoutePulse.Domain.Models;

namespace RoutePulse.Domain.Persistances.Entities;

public static class OrderMapper
{
    public static OrderEntity toEntity(this Order model)
    => new()
    {
        Id = model.Id,
        CustomerId = model.Id,
        AddressId = model.AddressId,
        Status = model.Status,
        PaymentMethod = model.PaymentMethod,
        PaymentStatus = model.PaymentStatus
    };
}
