using RoutePulse.Domain.Models;
using RoutePulse.Domain.Persistances.Entities;

namespace RoutePulse.Domain.Mappers;

public static class AddressMapper
{
    public static AddressEntity toEntity(this Address model)
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
