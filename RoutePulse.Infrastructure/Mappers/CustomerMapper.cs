using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class CustomerMapper
{
    public static CustomerEntity toEntity(this Customer model)
    => new()
    {
        Id = model.Id,
        FullName = model.FullName,
        Email = model.Email,
        PhoneNumber = model.PhoneNumber
    };
}
