using RoutePulse.Domain.Enums;

namespace RoutePulse.Domain.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    public Guid? AssignedCourierId { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Created;
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
    public decimal TotalAmount { get; private set; }

    public void SetTotalAmount(IEnumerable<OrderItem> items)
    {
        TotalAmount = items.Sum(x => x.Total);
    }
}
