using RoutePulse.Domain.Enums;

namespace RoutePulse.Domain.Models;

public class OrderStatusHistory
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid? AssignedCourierId { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
}
