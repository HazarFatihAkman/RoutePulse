using RoutePulse.Domain.Enums;

namespace RoutePulse.Domain.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    public Guid? AssignedCourierId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
    public OrderStatus Status { get; private set; }
    public decimal TotalAmount { get; private set; }

    public void SetTotalAmount(IEnumerable<OrderItem> items)
    {
        TotalAmount = items.Sum(x => x.Total);
    }

    public void MarkAsConfirmed()
    {
        if (OrderStatus.Confirmed - Status != 1) throw ValidateStatus(OrderStatus.Confirmed);
        Status = OrderStatus.Confirmed;
    }

    public void MarkAsPreparing()
    {
        if (OrderStatus.Preparing - Status != 1) throw ValidateStatus(OrderStatus.Preparing);
        Status = OrderStatus.Preparing;
    }

    public void MarkAsReadyForPickup()
    {
        if (OrderStatus.ReadyForPickup - Status != 1) throw ValidateStatus(OrderStatus.ReadyForPickup);
        Status = OrderStatus.ReadyForPickup;
    }

    public void MarkAsPickedUp()
    {
        if (OrderStatus.PickedUp - Status != 1) throw ValidateStatus(OrderStatus.PickedUp);
        Status = OrderStatus.PickedUp;
    }

    public void MarkAsOnTheWay()
    {
        if (OrderStatus.OnTheWay - Status != 1) throw ValidateStatus(OrderStatus.OnTheWay);
        Status = OrderStatus.OnTheWay;
    }

    public void MarkAsDelivered()
    {
        if (OrderStatus.Delivered - Status != 1) throw ValidateStatus(OrderStatus.Delivered);
        Status = OrderStatus.Delivered;
    }

    public void MarkAsCancelled()
    {
        //TODO: I will think about it and do later
        // if (Status == OrderStatus.Delivered) throw ValidateStatus(OrderStatus.Cancelled);
        Status = OrderStatus.Cancelled;
    }

    private InvalidOperationException ValidateStatus(OrderStatus orderStatus)
        => new($"You can't change Status to {orderStatus} cause it's already {Status}");
}
