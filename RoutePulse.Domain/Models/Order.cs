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
        if (Status > OrderStatus.Created) throw ValidateStatus(OrderStatus.Created);
        Status = OrderStatus.Created;
    }

    public void MarkAsConfirmed()
    {
        if (Status > OrderStatus.Confirmed) throw ValidateStatus(OrderStatus.Confirmed);
        Status = OrderStatus.Confirmed;
    }

    public void MarkAsPreparing()
    {
        if (Status > OrderStatus.Preparing) throw ValidateStatus(OrderStatus.Preparing);
        Status = OrderStatus.Preparing;
    }

    public void MarkAsReadyForPickup()
    {
        if (Status > OrderStatus.ReadyForPickup) throw ValidateStatus(OrderStatus.ReadyForPickup);
        Status = OrderStatus.ReadyForPickup;
    }

    public void MarkAsPickedUp()
    {
        if (Status > OrderStatus.PickedUp) throw ValidateStatus(OrderStatus.PickedUp);
        Status = OrderStatus.PickedUp;
    }

    public void MarkAsOnTheWay()
    {
        if (Status > OrderStatus.OnTheWay) throw ValidateStatus(OrderStatus.OnTheWay);
        Status = OrderStatus.OnTheWay;
    }

    public void MarkAsDelivered()
    {
        if (Status > OrderStatus.Delivered) throw ValidateStatus(OrderStatus.Delivered);
        Status = OrderStatus.Delivered;
    }

    public void MarkAsCancelled()
    {
        Status = OrderStatus.Cancelled;
    }

    private InvalidOperationException ValidateStatus(OrderStatus orderStatus)
        => new($"You can't change Status to {orderStatus} cause it's already {Status}");
}
