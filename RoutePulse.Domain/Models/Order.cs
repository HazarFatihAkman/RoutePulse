using RoutePulse.Domain.Enums;

namespace RoutePulse.Domain.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    public Guid? AssignedCourierId { get; set; }
    public OrderStatus Status { get; private set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
    public decimal TotalAmount { get; private set; }

    public void SetTotalAmount(IEnumerable<OrderItem> items)
    {
        TotalAmount = items.Sum(x => x.Total);
    }

    public void MarkAsCreated()
    {
        Status = OrderStatus.Created;
    }

    public void MarkAsConfirmed()
    {
        Status = OrderStatus.Confirmed;
    }

    public void MarkAsPreparing()
    {
        Status = OrderStatus.Preparing;
    }

    public void MarkAsReadyForPickup()
    {
        Status = OrderStatus.ReadyForPickup;
    }

    public void MarkAsPickedUp()
    {
        Status = OrderStatus.PickedUp;
    }

    public void MarkAsOnTheWay()
    {
        Status = OrderStatus.OnTheWay;
    }

    public void MarkAsDelivered()
    {
        Status = OrderStatus.Delivered;
    }

    public void MarkAsCancelled()
    {
        Status = OrderStatus.Cancelled;
    }
}
