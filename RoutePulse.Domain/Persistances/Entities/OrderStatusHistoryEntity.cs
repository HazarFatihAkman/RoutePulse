using RoutePulse.Domain.Models;

namespace RoutePulse.Domain.Persistances.Entities;

public class OrderStatusHistoryEntity : OrderStatusHistory
{
    public virtual OrderEntity Order { get; set; } = null!;
    public virtual CourierEntity? AssignedCourier { get; set; }
}
