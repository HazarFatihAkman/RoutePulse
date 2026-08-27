namespace RoutePulse.Domain.Models;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }

    // Min
    public required int PreparingTime { get; set; }
    public DateTime CreatedAt { get; set;}
    // There can be more detailed like description, barcode, img, etc.
    // but that's demo project and it's not necessary for now
}
