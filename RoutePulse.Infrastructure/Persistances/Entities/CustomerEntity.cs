using RoutePulse.Domain.Models;

namespace RoutePulse.Infrastructure.Persistances.Entities;

public class CustomerEntity : Customer
{
    public virtual ICollection<OrderEntity> Orders { get; set; } = [];
    public virtual ICollection<AddressEntity> Addresses { get; set; } = [];
}
