using RoutePulse.Domain.Models;

namespace RoutePulse.Infrastructure.Persistances.Entities;

public class AddressEntity : Address
{
    public virtual CustomerEntity Customer { get; set; } = null!;
}
