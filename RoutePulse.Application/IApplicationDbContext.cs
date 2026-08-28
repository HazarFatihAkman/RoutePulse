using Microsoft.EntityFrameworkCore;
using RoutePulse.Infrastructure.Persistances.Entities;

namespace RoutePulse.Application;

public interface IApplicationDbContext
{
    DbSet<AddressEntity> Addresses { get; }
    DbSet<CourierEntity> Couriers { get; }
    DbSet<CustomerEntity> Customers { get; }
    DbSet<OrderEntity> Orders { get; }
    DbSet<OrderItemEntity> OrderItems { get; }
    DbSet<OrderStatusHistoryEntity> OrderStatusHistories { get; }
    DbSet<ProductEntity> Products { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    int SaveChanges();
}
