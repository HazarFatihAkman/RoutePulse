using RoutePulse.Domain.Models;

namespace RoutePulse.Domain.Persistances.Entities;

public class CourierEntity : Courier
{
    public virtual List<OrderEntity> Orders { get; set;} = null!;
}
