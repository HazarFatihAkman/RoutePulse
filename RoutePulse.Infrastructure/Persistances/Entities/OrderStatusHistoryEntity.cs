using RoutePulse.Domain.Models;

namespace RoutePulse.Infrastructure.Persistances.Entities;

public class OrderStatusHistoryEntity : OrderStatusHistory
{
    public virtual OrderEntity Order { get; set; } = null!;
    public virtual CourierEntity? AssignedCourier { get; set; }
}
