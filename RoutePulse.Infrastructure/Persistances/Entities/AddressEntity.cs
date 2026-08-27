using RoutePulse.Domain.Models;

namespace RoutePulse.Domain.Persistances.Entities;

public class AddressEntity : Address
{
    public virtual CustomerEntity Customer { get; set; } = null!;
}
