using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

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
