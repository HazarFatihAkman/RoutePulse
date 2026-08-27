namespace RoutePulse.Domain.Models;

public class Courier
{
    public Guid Id { get; set; }
    public required string FullName { get; set; }
    public DateTime CreatedAt { get; set; }
    public CourierLocation? CurrentLocation { get; private set; }
    public double? CurrentSpeed { get; private set; }
    public DateTimeOffset? LastLocationUpdate { get; private set; }

    public void UpdateLocation(CourierLocation location, double speed)
    {
        CurrentLocation = location;
        CurrentSpeed = speed;
        LastLocationUpdate = DateTimeOffset.UtcNow;
    }
}
