using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class OrderMapper
{
    public static OrderEntity toEntity(this Order model)
    => new()
    {
        Id = model.Id,
        CustomerId = model.CustomerId,
        AddressId = model.AddressId,
        PaymentMethod = model.PaymentMethod,
        PaymentStatus = model.PaymentStatus
    };
}
