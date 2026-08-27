using RoutePulse.Domain.Models;

namespace RoutePulse.Domain.Persistances.Entities;

public class OrderItemEntity : OrderItem
{
    public virtual ProductEntity Product { get; set; } = null!;
    public virtual OrderEntity Order { get; set; } = null!;
}
