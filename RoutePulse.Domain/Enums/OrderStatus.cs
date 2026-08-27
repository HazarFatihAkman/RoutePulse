namespace RoutePulse.Domain.Enums;

public enum OrderStatus
{
    Created,
    Confirmed,
    Preparing,
    ReadyForPickup,
    PickedUp,
    OnTheWay,
    Delivered,
    Cancelled
}
