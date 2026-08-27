namespace RoutePulse.Domain.Models;

public class Address
{
    public Guid Id { get; set; }
    public required Guid CustomerId { get; set; }
    public required string AddressName { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public required string PostalCode { get; set; }
    public required string Floor { get; set; }
    public required string Flat { get; set; }
    public required string AddressDetail { get; set; }
    public DateTime CreatedAt { get; set; }
}
