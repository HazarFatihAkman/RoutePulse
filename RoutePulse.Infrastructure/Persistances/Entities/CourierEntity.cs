using RoutePulse.Domain.Models;

namespace RoutePulse.Infrastructure.Persistances.Entities;

public class CourierEntity : Courier
{
    public virtual List<OrderEntity> Orders { get; set;} = null!;
}
