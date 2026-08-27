using RoutePulse.Domain.Models;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Infrastructure.Mappers;

public static class AddressMapper
{
    public static AddressEntity ToEntity(this Address model)
    => new()
    {
        Id = model.Id,
        CustomerId = model.CustomerId,
        AddressName = model.AddressName,
        Country = model.Country,
        City = model.City,
        Street = model.Street,
        PostalCode = model.PostalCode,
        AddressDetail = model.AddressDetail,
        Floor = model.Floor,
        Flat = model.Flat,
        CreatedAt = model.CreatedAt
    }; 
}
