using RoutePulse.Domain.Models;

namespace RoutePulse.Domain.Persistances.Entities;

public class OrderEntity : Order
{
    public virtual CustomerEntity Customer { get; set; } = null!;
    public virtual AddressEntity Address { get; set; } = null!;
    public virtual CourierEntity? AssignedCourier { get; set; }
    public virtual ICollection<OrderItemEntity>? Items { get; set; }
}
