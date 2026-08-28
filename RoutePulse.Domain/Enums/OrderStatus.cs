namespace RoutePulse.Domain.Enums;

public enum OrderStatus
{
    Created = 0,
    Confirmed = 1,
    Preparing = 2,
    ReadyForPickup = 3,
    PickedUp = 4,
    OnTheWay = 5,
    Delivered = 6,
    Cancelled = 7
}
